using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointController : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public AudioClip sonidoCoin;
    public AudioSource audioSource;
    private GameManager gameManager;
    private int pointMinigame;

    private void Start()
    {
        gameManager = GameManager.Instance;
        UpdatePointsText();
        audioSource.clip = sonidoCoin;

        if (gameManager.FirstPlay)
        {
            gameManager.ResetPointsMinigame();
            gameManager.FirstPlay = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Point"))
        {
            audioSource.Play();
            gameManager.Points++;
            Destroy(col.gameObject);
            pointMinigame++;
            UpdatePointsText();
        }
    }

    private void OnDestroy()
    {
        if (pointMinigame > 0)
        {
            GameManager.Instance.PointsMinijuegos += pointMinigame;
        }

        pointMinigame = 0;
    }

    private int ObtenerPuntosGanados()
    {
        int puntosGanados = 1;
        pointMinigame += puntosGanados;
        return puntosGanados;
    }

    private void UpdatePointsText()
    {
        pointsText.text = pointMinigame.ToString();
    }
}
