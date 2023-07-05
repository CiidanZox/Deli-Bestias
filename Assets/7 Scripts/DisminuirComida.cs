using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisminuirComida : MonoBehaviour
{
    public Image barraImagen;
    private float velocidadDecremento = 0.1f;  
    private float tiempoDecremento = 60f; 

    private float tiempoTranscurrido = 0f;
    private float cantidadActual;

    private void Start()
    {
        barraImagen.fillAmount = cantidadActual;
    }

    private void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= tiempoDecremento)
        {
            tiempoTranscurrido = 0f;
            DecrementarBarra();
        }
    }

    private void DecrementarBarra()
    {
        cantidadActual -= velocidadDecremento;
        barraImagen.fillAmount = cantidadActual;

        if (cantidadActual <= 0f)
        {
            Debug.Log("La barra de comida se ha agotado.");
        }
        
    }
    
}
