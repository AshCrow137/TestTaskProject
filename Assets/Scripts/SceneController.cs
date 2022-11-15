using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
   
    private float selectedDifficult;
    private bool bIsSelected = false;
    [SerializeField]
    private Text noDifficultText;
    

    static SceneController instance;
    public static SceneController Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        instance = this;
        SaveSystemScript.LoadGame(); // ��� �������� �������� ���� ��������� ���� 
    }

    public void LoadScene(string sceneName)
    {
        if (bIsSelected)
        {
           StaticsVariables.horizontalSpeed = selectedDifficult;
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single); //��������� ����� ������ ���� ������� ���������
        }
        else
        {
            Debug.Log("����� �� �������");
            noDifficultText.gameObject.SetActive(true);
        }

  
    }

    public void SelectScene(float speedDifficult)
    {
        bIsSelected = true;
        noDifficultText.gameObject.SetActive(false);
        selectedDifficult = speedDifficult;
    }
    public void LoadGameOverScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

    }
    public void ClearDataButton()
    {
        SaveSystemScript.ClearData(); 
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
