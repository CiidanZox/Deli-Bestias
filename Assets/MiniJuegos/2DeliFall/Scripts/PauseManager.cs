using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public BoxCollider colliderInput;
    public CircleCollider2D colliderPlayer;
    public GameObject pauseButton;

    public void Pause()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        pausePanel.SetActive(true);
        colliderInput.enabled = false;
        colliderPlayer.enabled = false;
    }

    public void Reintentar()
    {
        SceneManager.LoadScene("3DeliFall");
    }

    public void Home()
    {
        SceneManager.LoadScene("1Principal");
    }

    public void Seguir()
    {
        pauseButton.SetActive(true);
        pausePanel.SetActive(false);
        colliderInput.enabled = true;
        colliderPlayer.enabled = true;
        Time.timeScale = 1;
    }
}
