using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
   
    private float selectedDifficult;
    private bool bIsSelected = false;

    static SceneController instance;
    public static SceneController Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        instance = this;
    }

    public void LoadScene(string sceneName)
    {
        if (bIsSelected)
        {
            PlayerMovement.hspeed = selectedDifficult;
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("—цена не выбрана");
        }
   
        

    }

    public void SelectScene(float speedDifficult)
    {
        bIsSelected = true;
        selectedDifficult = speedDifficult;
    }
    public void LoadGameOverScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

    }

}
