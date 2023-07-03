using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject inventoryPanel;
    public GameObject inventoryObject;
    public bool isActive;

    private static Inventory instance;
    private bool isInventoryActive;

    private void Start()
    {
        inventoryPanel.SetActive(false);
        inventoryObject.SetActive(false);
        isActive = false;
        instance = this;
    }
    
    public static Inventory Instance
    {
        get { return instance; }
    }

    public void ShowInventory()
    {
        isActive = !isActive;
        inventoryPanel.SetActive(isActive);
        inventoryObject.SetActive(isActive);

        if (isActive)
        {
            isInventoryActive = true;
            ActivateComidas();
        }
        else
        {
            isInventoryActive = false;
            DeactivateComidas();
        }
    }
    
    public void AddComidaInstance(GameObject comidaInstance)
    {
        comidaInstance.SetActive(isInventoryActive);
    }

    private void ActivateComidas()
    {
        GameObject[] comidas = GameObject.FindGameObjectsWithTag("Food");
        foreach (GameObject comida in comidas)
        {
            comida.SetActive(true);
        }
    }

    private void DeactivateComidas()
    {
        GameObject[] comidas = GameObject.FindGameObjectsWithTag("Food");
        foreach (GameObject comida in comidas)
        {
            comida.SetActive(false);
        }
    }
}
