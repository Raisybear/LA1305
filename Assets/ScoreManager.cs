using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text deathText;
    public static int deathCount;

    void Start()
    {
        deathCount = 0;
        UpdateDeathText(); 
    }

    void Update()
    {
        UpdateDeathText(); 
    }

    void UpdateDeathText() 
    {
        deathText.text = "Deaths: " + deathCount;
    }
}