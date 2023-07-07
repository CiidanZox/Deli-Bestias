using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventanas : MonoBehaviour
{
    public GameObject CerrarFelicitaciones;
    public GameObject CerrarDinero;
    
    public void CerrarFelici()
    {
        CerrarFelicitaciones.SetActive(false);
    }

    public void CerrarDineros()
    {
        CerrarDinero.SetActive(false);
    }
}
