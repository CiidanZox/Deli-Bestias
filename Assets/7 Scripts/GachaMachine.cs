using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class GachaMachine : MonoBehaviour
{
    public int gachaPrice = 100;
    public Transform resultPosition;
    public List<GameObject> spawnDeliBestias;
    public UnityEvent onSpin;

    private GameManager gameManager;
    private bool isSpinning = false;
    private List<GameObject> delibestiasDisponibles;

    private void Start()
    {
        gameManager = GameManager.Instance;
        delibestiasDisponibles = new List<GameObject>(spawnDeliBestias);
    }

    public void Spin()
    {
        if (!isSpinning && gameManager.Points >= gachaPrice && delibestiasDisponibles.Count > 0)
        {
            isSpinning = true;
            gameManager.Points -= gachaPrice;

            onSpin.Invoke();

            Debug.Log("Gacha spin successful!");
            
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
                
            PintsDisplay pintsDisplay = FindObjectOfType<PintsDisplay>();
            if (pintsDisplay != null)
            {
                pintsDisplay.UpdatePointsUI();
            }
        }
        else if (isSpinning)
        {
            Debug.Log("El gacha se esta realizando!");
        }
        
        else if (gameManager.Points < gachaPrice)
        {
            Debug.Log("No hay suficientes monedas para comprar!");
        }
        
        else if (delibestiasDisponibles.Count == 0)
        {
            Debug.Log("No hay mas delibestias disponibles en el gacha!");
        }
    }
}

