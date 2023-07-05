using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar2 : MonoBehaviour
{
    public float food = 0.2f;
    public Image foodBar;
    public Transform initialPosition;
    private bool comidaCollider = false;
    public TMPro.TextMeshProUGUI inventoryText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food2"))
        {
            comidaCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food2"))
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
                Destroy(GameObject.FindGameObjectWithTag("Food2"));
                
                int currentQuantity = int.Parse(inventoryText.text);
                if (currentQuantity > 0)
                {
                    currentQuantity--;
                    inventoryText.text = currentQuantity.ToString();
                }
            }
            else if (foodBar.fillAmount >= 1f)
            {
                GameObject.FindGameObjectWithTag("Food2").transform.position = initialPosition.position;
            }
            
        }
    }
}
