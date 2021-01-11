﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;
    public TextMeshProUGUI text;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score = score + coinValue;
        text.text = "x" + score.ToString();
    }
}
