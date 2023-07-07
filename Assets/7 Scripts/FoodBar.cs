using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Scripting;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class FoodBar : MonoBehaviour
{
    public float food = 0.2f;
    public Image foodBar;
    public Transform initialPosition;
    public AudioClip sonidoComer;
    public AudioSource audioSource;
    private bool comidaCollider = false;
    public TMPro.TextMeshProUGUI inventoryText;

    private void Start()
    {
        audioSource.clip = sonidoComer;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            comidaCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            comidaCollider = false;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && comidaCollider)
        {
            if (foodBar.fillAmount < 1f)
            {
                foodBar.fillAmount += food;
                audioSource.Play();
                Destroy(GameObject.FindGameObjectWithTag("Food"));
                
                int currentQuantity = int.Parse(inventoryText.text);
                if (currentQuantity > 0)
                {
                    currentQuantity--;
                    inventoryText.text = currentQuantity.ToString();
                }
            }
            else if (foodBar.fillAmount >= 1f)
            {
                GameObject.FindGameObjectWithTag("Food").transform.position = initialPosition.position;
            }
        }
    }
 
}
