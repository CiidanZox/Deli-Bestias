using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonDormir : MonoBehaviour
{
   public GameObject panelDormir;
   public GameObject playerDurmiendo;
   public GameObject playerDespierto;
   public Image barraEnergia;
   public GameObject noHayEnergia;

   private bool isPressed;
   private Coroutine incrementarBarraCoroutine;
   private float savedFillAmount;

   private void Start()
   {
      noHayEnergia.SetActive(false);
      isPressed = false;
      playerDurmiendo.SetActive(false);
      
      savedFillAmount = PlayerPrefs.GetFloat("FillAmount", 0f);
      barraEnergia.fillAmount = savedFillAmount;
   }

   private void Update()
   {
      if (barraEnergia.fillAmount >= 1f)
      {
         panelDormir.SetActive(false);
         playerDurmiendo.SetActive(false);
         playerDespierto.SetActive(true);
         isPressed = false;
      }
   }

   public void BotonMimir()
   {
      if (isPressed == false)
      {
         panelDormir.SetActive(true);
         playerDurmiendo.SetActive(true);
         playerDespierto.SetActive(false);
         isPressed = true;
         
         incrementarBarraCoroutine = StartCoroutine(IncrementarBarraEnergia());
      }

      else if (isPressed == true)
      {
         panelDormir.SetActive(false);
         playerDurmiendo.SetActive(false);
         playerDespierto.SetActive(true);
         isPressed = false;
         
         if (incrementarBarraCoroutine != null) StopCoroutine(incrementarBarraCoroutine);
      }
      
   }

   public void RestarEnergia()
   {
      if (barraEnergia.fillAmount > 0f)
      {
         barraEnergia.fillAmount -= 0.1f;
         
         if (barraEnergia.fillAmount < 0f)
         {
            barraEnergia.fillAmount = 0f;
         }
      }
   }
   
   private System.Collections.IEnumerator IncrementarBarraEnergia()
   {
      while (barraEnergia.fillAmount < 1f)
      {
         barraEnergia.fillAmount += 0.1f;
         yield return new WaitForSeconds(1f);
      }
   }
   
   private void OnApplicationQuit()
   {
      PlayerPrefs.SetFloat("FillAmount", barraEnergia.fillAmount);
      PlayerPrefs.Save();
   }
   
   private void OnDisable()
   {
      PlayerPrefs.SetFloat("FillAmount", barraEnergia.fillAmount);
      PlayerPrefs.Save();
   }
   
   public void DeleteEnergy()
   {
      PlayerPrefs.DeleteKey("FillAmount");
      PlayerPrefs.Save();
      
      barraEnergia.fillAmount = 0f;
      panelDormir.SetActive(false);
      playerDurmiendo.SetActive(false);
      playerDespierto.SetActive(true);
      isPressed = false;
   }

   public void CerrarVentana()
   {
      noHayEnergia.SetActive(false);
   }
}
