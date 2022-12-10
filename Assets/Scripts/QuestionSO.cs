using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "Question _")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 8)] [SerializeField] private string question = "Enter new question text here";

    [TextArea(2, 8)] [SerializeField] private string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    [SerializeField] int scoreValue;
    
    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public int GetScoreValue()
    {
        return scoreValue;
    }
}
