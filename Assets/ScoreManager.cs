using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text deathText;
    public static int deathCount;

    void Start()
    {
        deathCount = 0;
        UpdateDeathText(); // Umbenannte Methode
    }

    void Update()
    {
        UpdateDeathText(); // Umbenannte Methode
    }

    void UpdateDeathText() // Umbenannte Methode
    {
        deathText.text = "Deaths: " + deathCount;
    }
}
