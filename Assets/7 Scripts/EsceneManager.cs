using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EsceneManager : MonoBehaviour
{

    public void Reiniciar()
    {
        SceneManager.LoadScene("2SpaceBeast");
    }

    public void SpaceBeast()
    {
        SceneManager.LoadScene("2SpaceBeast");
    }

    public void DeliFall()
    {
        SceneManager.LoadScene("3DeliFall");
    }

    public void DeliFood()
    {
        SceneManager.LoadScene("4DeliFood");
    }

    public void Principal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("1Principal");
    }
    public void ResetGameData()
    {
        GameManager.Instance.Points = 0;
        GameManager.Instance.PointsMinigame = 0;
        GameManager.Instance.FirstPlay = true;
        
        string saveFilePath = Application.persistentDataPath + "/saveData.dat";
        if (System.IO.File.Exists(saveFilePath))
        {
            System.IO.File.Delete(saveFilePath);
        }
     
        SceneManager.LoadScene("1Principal");
    }
    
}
