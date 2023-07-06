using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{
    public GameObject officialCanvas;
    public GameObject iniciandoJuego;
    public GameObject perdiendoJuego;
    public GameObject botonPausa;
    public GameObject pausaPanel;

    private void Start()
    {
        Time.timeScale = 0;
        botonPausa.SetActive(false);
        officialCanvas.SetActive(true);
        iniciandoJuego.SetActive(true);
    }

    public void Iniciar()
    {
        officialCanvas.SetActive(true);
        iniciandoJuego.SetActive(false);
        botonPausa.SetActive(true);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        officialCanvas.SetActive(true);
        perdiendoJuego.SetActive(true);
        botonPausa.SetActive(false);
        Time.timeScale = 0;
    }

    public void Pausa()
    {
        Time.timeScale = 0;
        pausaPanel.SetActive(true);
        botonPausa.SetActive(false);
    }
    
    public void CerrarPausa()
    {
        Time.timeScale = 1;
        pausaPanel.SetActive(false);
        botonPausa.SetActive(true);
    }


}
