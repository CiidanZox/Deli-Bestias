using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DJSceneManager : MonoBehaviour
{
    public GameObject starPanel;
    public GameObject pausePanel;
    public GameObject losePanel;

    private void Start()
    {
        starPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Play()
    {
        Time.timeScale = 1f;
        starPanel.SetActive(false);
    }

    public void Return()
    {
        losePanel.SetActive(false);
        SceneManager.LoadScene("4DeliFood");
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void Continuar()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1Principal");
    }


}
