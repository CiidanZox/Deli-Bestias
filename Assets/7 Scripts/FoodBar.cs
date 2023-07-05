using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Scripting;

public class FoodBar : MonoBehaviour
{
    public float food = 0.2f;
    public Image foodBar;
    public Transform initialPosition;
    private bool comidaCollider = false;

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
                Destroy(GameObject.FindGameObjectWithTag("Food"));
            }
            else if (foodBar.fillAmount >= 1f)
            {
                GameObject.FindGameObjectWithTag("Food").transform.position = initialPosition.position;
            }
        }
    }

}
