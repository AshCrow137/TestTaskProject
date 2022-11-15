using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    

    private Text timerText;
    private float gameTime;

    private void Awake()
    {
        //Выставляем таймер в секундах и минутах 
        timerText = GetComponent<Text>();
        gameTime = StaticsVariables.gameTime;

        float seconds = Mathf.FloorToInt(gameTime % 60);
        float minutes = Mathf.FloorToInt(gameTime / 60);

        timerText.text = "Время: " + String.Format("{00:00}:{01:00}", minutes, seconds); 
    }

}
