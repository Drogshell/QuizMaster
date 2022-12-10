using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Quiz quiz;
    private EndScreen endScreen;
    
    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<EndScreen>();
        
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (quiz.gameEnded)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            if (quiz.GetQuestionListCount() == 0)
            {
                endScreen.ShowFinalScore("Congratulations!\nYou answered all questions correctly!\n");
            }
            else
            {
                endScreen.ShowFinalScore("Ouch!\nBetter luck next time!\n");
            }
        }
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
