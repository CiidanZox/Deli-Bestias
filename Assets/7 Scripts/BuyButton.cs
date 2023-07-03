using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BuyButton : MonoBehaviour
{
    public int precio = 50;
    public GameObject frutillaPrefab;
    public UnityEvent onPurchase;
    public TMPro.TextMeshProUGUI inventoryText;
    public Inventory inventoryManager;

    private Button buttonFrutilla;
    private static bool isInventory;
    private GameManager gameManager;
    void Start()
    {
        buttonFrutilla = GetComponent<Button>();
        gameManager = GameManager.Instance;
        isInventory = false;
        onPurchase.AddListener(AttempToBuy);
        
        inventoryManager = FindObjectOfType<Inventory>();
        
        buttonFrutilla.onClick.AddListener(AttempToBuy);
    }

    private void AttempToBuy()
    {
        if (GameManager.Instance.Points >= precio)
        {
            gameManager.Points -= precio;
            
            onPurchase.Invoke();
            
            Debug.Log("!Compra Exitosa!");
            
            Vector3 frutillaPosition = new Vector3(1.4f, 3.3f, 0f);
            
            GameObject frutillaInstance = Instantiate(frutillaPrefab, frutillaPosition, Quaternion.identity);
            isInventory = true;
            
            frutillaInstance.transform.SetParent(Inventory.Instance.inventoryObject.transform);
            
            Inventory.Instance.AddComidaInstance(frutillaInstance);

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
    
    public static bool IsInInventory()
    {
        return isInventory;
    }
}
