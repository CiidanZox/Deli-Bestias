using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJTriggerEnemy : MonoBehaviour
{

    public GameObject lostPanel;
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            lostPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
