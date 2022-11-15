using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCountScript : MonoBehaviour
{
    private Text countText;

    private void Awake()
    {

        countText = GetComponent<Text>();
        countText.text = "Количество попыток: " + StaticsVariables.gameCount.ToString();


    }
}
