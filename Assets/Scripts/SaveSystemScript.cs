using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystemScript : MonoBehaviour
{
    
public static void SaveGame()
    {
        PlayerPrefs.SetInt("GameCount", StaticsVariables.gameCount);
        PlayerPrefs.Save();

    }
    public static void LoadGame()
    {
        if(PlayerPrefs.HasKey("GameCount"))
        {
            StaticsVariables.gameCount = PlayerPrefs.GetInt("GameCount");
        }
        else
        {
            Debug.Log("No save data");
        }
    }
    public static void ClearData()
    {
        PlayerPrefs.DeleteAll();
        StaticsVariables.gameCount = 0;
    }

}
