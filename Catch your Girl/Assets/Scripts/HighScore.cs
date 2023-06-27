using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    private void Start()
    {
        UpdateHighScoreText();
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
}
