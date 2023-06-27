using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UiManager : MonoBehaviour
{
    public RectTransform panelController, options, minijuegos, foodEnergy, shopPoints, gacha;

    public void ChoosePanel(float posX)
    {
        panelController.DOAnchorPosX(posX, .25f);
    }

    private void Start()
    {
        ChoosePanel(0);
    }

    public void Options()
    {
        options.DOAnchorPos(new Vector2(0, 0), 0.40f);
    }

    public void CloseOptions()
    {
        options.DOAnchorPos(new Vector2(0, 820), 0.40f);
    }

    public void Minijuegos()
    {
        minijuegos.DOAnchorPos(new Vector2(0, 0), 0.1f);
    }

    public void CloseMinijuegos()
    {
        minijuegos.DOAnchorPos(new Vector2(0, 1460),0.1f);
    }

    public void FoodEnergy()
    {
        foodEnergy.DOAnchorPos(new Vector2(0, -37), 0.1f);
    }

    public void CloseFoodEnergy()
    {
        foodEnergy.DOAnchorPos(new Vector2(0, 1870),0.1f);
    }

    public void ShopPoints()
    {
        shopPoints.DOAnchorPos(new Vector2(0, 15), 2.8f);
    }

    public void CloseShopPoints()
    {
        shopPoints.DOAnchorPos(new Vector2(-550, 0), 2.8f);
    }

    public void Gacha()
    {
        gacha.DOAnchorPos(new Vector2(0, 320), 4f);
    }

    public void CloseGacha()
    {
        gacha.DOAnchorPos(new Vector2(550, 320), 0f);
    }
}
