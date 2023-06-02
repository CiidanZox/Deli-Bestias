using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemy : MonoBehaviour
{
    public GameObject failPanel;
    public GameObject pauseButton;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            failPanel.SetActive(true);
            pauseButton.SetActive(false);
        }
    }
}
