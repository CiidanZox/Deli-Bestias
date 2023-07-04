using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public List<GameObject> skinsDeliBestias;
    public GameObject deliBestiaOriginal;

    public void ActivarD1()
    {
        skinsDeliBestias[0].SetActive(true);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }

    public void ActivarD2()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(true);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }
    public void ActivarD3()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(true);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }
    
    public void ActivarD4()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(true);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }
    
    public void ActivarD5()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(true);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }
    
    public void ActivarD6()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(true);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }
    
    public void ActivarD7()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(true);
        skinsDeliBestias[7].SetActive(false);
        deliBestiaOriginal.SetActive(false);
    }
    
    public void ActivarD8()
    {
        skinsDeliBestias[0].SetActive(false);
        skinsDeliBestias[1].SetActive(false);
        skinsDeliBestias[2].SetActive(false);
        skinsDeliBestias[3].SetActive(false);
        skinsDeliBestias[4].SetActive(false);
        skinsDeliBestias[5].SetActive(false);
        skinsDeliBestias[6].SetActive(false);
        skinsDeliBestias[7].SetActive(true);
        deliBestiaOriginal.SetActive(false);
    }
    
    

}
