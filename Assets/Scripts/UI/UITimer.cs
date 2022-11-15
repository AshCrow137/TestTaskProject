using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : MonoBehaviour
{
    private Text timerText;


    private void Awake()
    {
        timerText = GetComponent<Text>();


    }
  
    private void Update()  
    {
        //Рисуем таймер и приводим его к минутам : секундам
        float localTime = StaticsVariables.gameTime;
        float seconds = Mathf.FloorToInt(localTime % 60);
        float minutes = Mathf.FloorToInt(localTime / 60);

        timerText.text = String.Format("{00:00}:{01:00}", minutes, seconds);
    }
}
