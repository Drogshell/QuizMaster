using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;
    private ScoreKeeper scoreKeeper;
    
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore(string prompt)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(prompt);
        sb.Append($"Questions answered: {scoreKeeper.CorrectAnswers:D}\nYour Final Score is: {scoreKeeper.GetCurrentScore():D}");
        finalScoreText.text = sb.ToString();
    }
}
