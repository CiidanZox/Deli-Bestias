using System.Collections;
using System.Collections.Generic;
using CI.QuickSave;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BuyPina : MonoBehaviour
{
    public int precio = 50;
    public GameObject zanahoriaPrefab;
    public UnityEvent onPurchase;
    public TMPro.TextMeshProUGUI inventoryText;

    private Button buttonFrutilla;
    private GameManager gameManager;
    void Start()
    {
        buttonFrutilla = GetComponent<Button>();
        gameManager = GameManager.Instance;

        buttonFrutilla.onClick.AddListener(AttempToBuy);
    }

    private void AttempToBuy()
    {
        if (gameManager.Points >= precio)
        {
            gameManager.Points -= precio;
            
            onPurchase.Invoke();
            
            Debug.Log("!Compra Exitosa!");
            
            Vector3 frutillaPosition = new Vector3(-1.5f, 3f, 0f);
            Instantiate(zanahoriaPrefab, frutillaPosition, Quaternion.identity);
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
