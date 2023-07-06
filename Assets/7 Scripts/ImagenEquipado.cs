using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagenEquipado : MonoBehaviour
{
   public List<GameObject> imagenesEquipado;
   public List<GameObject> botonesEquipar;

   public void Equipado1()
   {
      imagenesEquipado[0].SetActive(true);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(false);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(true);
   }
   
   public void Equipado2()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(true);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(false);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(true);
   }
   
   public void Equipado3()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(true);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(false);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(true);
   }
   
   public void Equipado4()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(true);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(false);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(true);
   }
   
   public void Equipado5()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(true);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(false);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(true);
   }
   
   public void Equipado6()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(true);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(false);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(true);
   }
   public void Equipado7()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(true);
      imagenesEquipado[7].SetActive(false);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(false);
      botonesEquipar[7].SetActive(true);
   }
   
   public void Equipado8()
   {
      imagenesEquipado[0].SetActive(false);
      imagenesEquipado[1].SetActive(false);
      imagenesEquipado[2].SetActive(false);
      imagenesEquipado[3].SetActive(false);
      imagenesEquipado[4].SetActive(false);
      imagenesEquipado[5].SetActive(false);
      imagenesEquipado[6].SetActive(false);
      imagenesEquipado[7].SetActive(true);
      botonesEquipar[0].SetActive(true);
      botonesEquipar[1].SetActive(true);
      botonesEquipar[2].SetActive(true);
      botonesEquipar[3].SetActive(true);
      botonesEquipar[4].SetActive(true);
      botonesEquipar[5].SetActive(true);
      botonesEquipar[6].SetActive(true);
      botonesEquipar[7].SetActive(false);
   }

}
