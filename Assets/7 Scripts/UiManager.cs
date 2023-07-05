using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UiManager : MonoBehaviour
{
    public RectTransform panelController, options, minijuegos, foodEnergy, shopPoints, gacha ,galeria, botonDormir;

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
        options.DOAnchorPos(new Vector2(0, 6420), 0.40f);
    }

    public void Minijuegos()
    {
        minijuegos.DOAnchorPos(new Vector2(0, 0), 0.1f);
    }

    public void CloseMinijuegos()
    {
        minijuegos.DOAnchorPos(new Vector2(0, 6420),0.1f);
    }

    public void FoodEnergy()
    {
        foodEnergy.DOAnchorPos(new Vector2(0, -3433), 0.1f);
    }

    public void CloseFoodEnergy()
    {
        foodEnergy.DOAnchorPos(new Vector2(0, 6420),0.1f);
    }

    public void ShopPoints()
    {
        shopPoints.DOAnchorPos(new Vector2(0, 0), .5f);
    }

    public void CloseShopPoints()
    {
        shopPoints.DOAnchorPos(new Vector2(-3305, 0), .5f);
    }

    public void Gacha()
    {
        gacha.DOAnchorPos(new Vector2(0, 0), 0.3f);
    }

    public void CloseGacha()
    {
        gacha.DOAnchorPos(new Vector2(550, 13330), 0f);
    }

    public void Galeria()
    {
        galeria.DOAnchorPos(new Vector2(0, 0),0.5f);
    }

    public void CloseGaleria()
    {
        galeria.DOAnchorPos(new Vector2(0, 13330), 0.5f);
    }

    public void BotonDormir()
    {
        botonDormir.DOAnchorPos(new Vector2(0, 0), 0.1f);
    }

    public void CloseBotonDormir()
    {
        botonDormir.DOAnchorPos(new Vector2(0, 6420),0.1f);
    }
}
