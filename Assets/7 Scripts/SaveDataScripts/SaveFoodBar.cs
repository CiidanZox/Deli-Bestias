using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class FoodBarData
{
    public float fillAmount;

    public FoodBarData(float fillAmount)
    {
        this.fillAmount = fillAmount;
    }
}
public class SaveFoodBar : MonoBehaviour
{
    public Image foodBar;
    private string savePath;

    private void Awake()
    {
        savePath = Application.persistentDataPath + "/foodBarData.dat";
    }

    private void OnEnable()
    {
        LoadFoodBarData();
    }

    private void OnDisable()
    {
        SaveFoodBarData();
    }

    private void SaveFoodBarData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fileStream = File.OpenWrite(savePath);

        FoodBarData foodBarData = new FoodBarData(foodBar.fillAmount);

        formatter.Serialize(fileStream, foodBarData);
        fileStream.Close();
    }

    private void LoadFoodBarData()
    {
        if (File.Exists(savePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = File.OpenRead(savePath);

            FoodBarData foodBarData = (FoodBarData)formatter.Deserialize(fileStream);

            foodBar.fillAmount = foodBarData.fillAmount;

            fileStream.Close();
        }
    }
    
    public float GetFillAmount()
    {
        return foodBar.fillAmount;
    }

    public void SetFillAmount(float fillAmount)
    {
        foodBar.fillAmount = fillAmount;
    }
}


