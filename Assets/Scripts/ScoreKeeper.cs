using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int CorrectAnswers { get; set; }
    private int score;

    public void AddPoints(int points)
    {
        score += points;
        CorrectAnswers++;
    }

    public int GetCurrentScore()
    {
        return score;
    }
}
