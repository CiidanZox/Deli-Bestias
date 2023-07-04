using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BuyZanahora : MonoBehaviour
{
    public int precio = 50;
    public GameObject zanahoriaPrefab;
    public GameObject fireprefab;
    public UnityEvent onPurchase;
    public TMPro.TextMeshProUGUI inventoryText;
    public Inventory inventory;

    private Button buttonFrutilla;
    private GameManager gameManager;
    void Start()
    {
        buttonFrutilla = GetComponent<Button>();
        gameManager = GameManager.Instance;
        
        inventory = FindObjectOfType<Inventory>();
        
        buttonFrutilla.onClick.AddListener(AttempToBuy);
    }

    private void AttempToBuy()
    {
        if (gameManager.Points >= precio)
        {
            gameManager.Points -= precio;
            
            onPurchase.Invoke();
            
            Debug.Log("!Compra Exitosa!");

            if (inventory.isActiveAndEnabled)
            {
                Vector3 frutillaPosition = new Vector3(0.28f, 3.33f, 0f);
                Instantiate(zanahoriaPrefab, frutillaPosition, Quaternion.identity);
            }
            int currentQuantity = int.Parse(inventoryText.text);
            currentQuantity++;
            inventoryText.text = currentQuantity.ToString();

            PintsDisplay pintsDisplay = FindObjectOfType<PintsDisplay>();
            if (pintsDisplay != null)
            {
                pintsDisplay.UpdatePointsUI();
            }
        }
        else
        {
            Debug.Log("!No tienes suficientes monedas para comprar!");
        }
        
    }
}
