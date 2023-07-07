using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoManager : MonoBehaviour
{
    public List<GameObject> Tutorial;


    public void Boton()
    {
        Tutorial[0].SetActive(false);
        Tutorial[1].SetActive(true);
        Tutorial[2].SetActive(false);
        Tutorial[3].SetActive(false);
        Tutorial[4].SetActive(false);
        Tutorial[5].SetActive(false);
    }

    public void Boton1()
    {
        Tutorial[0].SetActive(false);
        Tutorial[1].SetActive(false);
        Tutorial[2].SetActive(true);
        Tutorial[3].SetActive(false);
        Tutorial[4].SetActive(false);
        Tutorial[5].SetActive(false);
    }
    
    public void Boton2()
    {
        Tutorial[0].SetActive(false);
        Tutorial[1].SetActive(false);
        Tutorial[2].SetActive(false);
        Tutorial[3].SetActive(true);
        Tutorial[4].SetActive(false);
        Tutorial[5].SetActive(false);
    }
    
    public void Boton3()
    {
        Tutorial[0].SetActive(false);
        Tutorial[1].SetActive(false);
        Tutorial[2].SetActive(false);
        Tutorial[3].SetActive(false);
        Tutorial[4].SetActive(true);
        Tutorial[5].SetActive(false);
    }
    
    public void Boton4()
    {
        Tutorial[0].SetActive(false);
        Tutorial[1].SetActive(false);
        Tutorial[2].SetActive(false);
        Tutorial[3].SetActive(false);
        Tutorial[4].SetActive(false);
        Tutorial[5].SetActive(true);
    }
    
    public void Boton5()
    {
        Tutorial[0].SetActive(true);
        Tutorial[1].SetActive(false);
        Tutorial[2].SetActive(false);
        Tutorial[3].SetActive(false);
        Tutorial[4].SetActive(false);
        Tutorial[5].SetActive(false);
    }
}
