using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public CircleCollider2D colliderPlayer;
    public BoxCollider colliderInput;
    public GameObject tutorialImage;
    public GameObject pauseButton;

    private TriggerEnemy triggerEnemy;

    private void Start()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        tutorialImage.SetActive(true);
        colliderInput.enabled = false;
        colliderPlayer.enabled = false;
    }

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            colliderInput.enabled = false;
            colliderPlayer.enabled = false;
        }
    }

    public void OnButtonClicked()
    {
        tutorialImage.SetActive(false);
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        colliderInput.enabled = true;
        colliderPlayer.enabled = true;
    }
}
