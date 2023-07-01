using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{
    public GameObject officialCanvas;
    public GameObject iniciandoJuego;
    public GameObject perdiendoJuego;

    private void Start()
    {
        Time.timeScale = 0;
        officialCanvas.SetActive(true);
        iniciandoJuego.SetActive(true);
    }

    public void Iniciar()
    {
        officialCanvas.SetActive(false);
        iniciandoJuego.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        officialCanvas.SetActive(true);
        perdiendoJuego.SetActive(true);
        Time.timeScale = 0;
    }


}
