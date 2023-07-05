using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniGamesEscene : MonoBehaviour
{
   public GameObject ventanaEnergia;
   public Image energiaFillAmount;

   private bool isEnergyOFF;
   private bool isEnergyONN;

   private void Update()
   {
      isEnergyOFF = energiaFillAmount.fillAmount < 0.2f;
      isEnergyONN = energiaFillAmount.fillAmount >= 0.2f;
   }

   public void DeliJump()
   {
      if (isEnergyONN)
      {
         SceneManager.LoadScene("2SpaceBeast");
      }
      else if (isEnergyOFF)
      {
         ventanaEnergia.SetActive(true);
      }
   }
   
   public void DeliFall()
   {
      if (isEnergyONN)
      {
         SceneManager.LoadScene("3DeliFall");
      }
      else if (isEnergyOFF)
      {
         ventanaEnergia.SetActive(true);
      }
   }
   
   public void DeliFood()
   {
      if (isEnergyONN)
      {
         SceneManager.LoadScene("4DeliFood");
      }
      else if (isEnergyOFF)
      {
         ventanaEnergia.SetActive(true);
      }
   }
}
