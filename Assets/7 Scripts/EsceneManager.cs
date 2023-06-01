using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void DeliJump()
    {
        SceneManager.LoadScene("3DeliFall");
    }
    
    public void Principal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("1Principal");
    }

}
