using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BuyButton : MonoBehaviour
{
    public int precio = 50;
    public GameObject frutillaPrefab;
    public UnityEvent onPurchase;

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
            
            Vector3 frutillaPosition = new Vector3(-2.26f, -2.78f, 0f);

            Instantiate(frutillaPrefab, frutillaPosition, Quaternion.identity);

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
