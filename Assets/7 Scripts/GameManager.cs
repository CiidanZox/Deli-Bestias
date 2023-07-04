using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



[System.Serializable]
public partial class GameData
{
    public int points;
    public int pointsMinigame;
    public bool firstPlay;
}

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int points;
    private int pointsMinigame;
    private bool firstPlay = true;
    private int _pointsMinigame = 0;

    private string saveFilePath;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.root.gameObject);

            saveFilePath = Application.persistentDataPath + "/saveData.dat";
            LoadGameData();

            if (!SceneManager.GetSceneByName("0Null").isLoaded)
            {
                SceneManager.LoadScene("0Null", LoadSceneMode.Additive);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void AddPoints()
    {
        points += _pointsMinigame;
        _pointsMinigame = 0;
    }

    public static GameManager Instance
    {
        get { return instance; }
    }

    public int Points
    {
        get { return points + GameManager.instance.pointsMinigame; }
        set { points = value; }
    }

    public int PointsMinigame

    {
        get { return pointsMinigame; }
        set { pointsMinigame = value; }
    }

    public bool FirstPlay
    {
        get { return firstPlay; }
        set { firstPlay = value; }
    }

    public void ResetPointsMinigame()
    {
        pointsMinigame = 0;
    }
    
    public void SaveGameData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(saveFilePath);

        GameData data = new GameData();
        data.points = points;
        data.pointsMinigame = pointsMinigame;
        data.firstPlay = firstPlay;

        bf.Serialize(file, data);
        file.Close();
    }
    
    public void LoadGameData()
    {
        if (File.Exists(saveFilePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(saveFilePath, FileMode.Open);

            GameData data = (GameData)bf.Deserialize(file);
            file.Close();

            points = data.points;
            pointsMinigame = data.pointsMinigame;
            firstPlay = data.firstPlay;
        }
        else
        {
            points = 0;
            pointsMinigame = 0;
            firstPlay = true;
        }
    }
    
    private void OnApplicationQuit()
    {
        SaveGameData();
    }


    public int PointsMinijuegos { get; set; }
}


