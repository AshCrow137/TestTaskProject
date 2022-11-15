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
        //���������� ������ � �������� � ������� 
        timerText = GetComponent<Text>();
        gameTime = StaticsVariables.gameTime;

        float seconds = Mathf.FloorToInt(gameTime % 60);
        float minutes = Mathf.FloorToInt(gameTime / 60);

        timerText.text = "�����: " + String.Format("{00:00}:{01:00}", minutes, seconds); 
    }

}
