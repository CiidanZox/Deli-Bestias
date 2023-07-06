using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;
using System.IO;
using Newtonsoft.Json;

[System.Serializable]
public class ObjectConnection
{
    public GameObject delibestia;
    public GameObject objetoConectar;
    public GameObject buttonBlocked;
}

public class GachaMachine : MonoBehaviour
{
    public int gachaPrice = 100;
    public Transform resultPosition;
    public List<GameObject> spawnDeliBestias;
    public List<ObjectConnection> objectConnections;
    public List<GameObject> buttonBlocked;
    public UnityEvent onSpin;
    public AudioClip audioRefri;
    public AudioSource audioSource;
    public Animator refriAnimation;

    private GameManager gameManager;
    private bool isSpinning = false;
    private List<GameObject> delibestiasDisponibles;
    

    private void Start()
    {
        gameManager = GameManager.Instance;
        delibestiasDisponibles = new List<GameObject>(spawnDeliBestias);
        audioSource.clip = audioRefri;
        
    }

    public void Spin()
    {
        if (!isSpinning && gameManager.Points >= gachaPrice && delibestiasDisponibles.Count > 0)
        {
            isSpinning = true;
            gameManager.Points -= gachaPrice;

            onSpin.Invoke();

            Debug.Log("Gacha spin successful!");

            ReproducirAnimacion();

            StartCoroutine(SpinRoutine());
        }
        else if (isSpinning)
        {
            Debug.Log("El gacha se está realizando!");
        }
        else if (gameManager.Points < gachaPrice)
        {
            Debug.Log("¡No hay suficientes monedas para comprar!");
        }
        else if (delibestiasDisponibles.Count == 0)
        {
            Debug.Log("¡No hay más delibestias disponibles en el gacha!");
        }
    }

    private IEnumerator SpinRoutine()
    {
        yield return new WaitForSeconds(2.5f); // Espera de 4 segundos

        int randomIndex = UnityEngine.Random.Range(0, delibestiasDisponibles.Count);
        GameObject resultObject = delibestiasDisponibles[randomIndex];

        Vector3 spawnPosition = transform.position;
        spawnPosition.y = -10f;

        Vector3 deliPosition = new Vector3(0.1f, 0.1f, 0.1f);

        Transform spawnedObject = Instantiate(resultObject, deliPosition, Quaternion.identity).transform;

        spawnedObject.DOScale(deliPosition * 1.5f, 1f).SetEase(Ease.OutBounce);

        spawnedObject.DOMove(resultPosition.position, 1f).SetEase(Ease.OutQuint).OnComplete(() =>
        {
            Destroy(spawnedObject.gameObject, 1f);
            isSpinning = false;
        });

        delibestiasDisponibles.RemoveAt(randomIndex);

        ObjectConnection connection = objectConnections.Find(con => con.delibestia == resultObject);
        if (connection != null)
        {
            GameObject objetoConectar = connection.objetoConectar;
            GameObject buttonBlock = connection.buttonBlocked;

            objetoConectar.SetActive(false);
            buttonBlock.SetActive(false);

            objetoConectar.transform.position = resultPosition.position;
        }
 
        PintsDisplay pintsDisplay = FindObjectOfType<PintsDisplay>();
        if (pintsDisplay != null)
        {
            pintsDisplay.UpdatePointsUI();
        }
    }
    
    public void ReproducirAnimacion()
    {
        refriAnimation.Play("refriAnimacion", -1, 0f);
        audioSource.Play();
    }
    
}