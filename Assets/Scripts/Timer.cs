using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public float timerValue;
    public bool loadNextQuestion=true;
    public float fillFraction;

    public bool isAnsweringQuestion = true;
    private void Update()
    {
        UpdateTimer();
    }
    void UpdateTimer()
    {
        timerValue = timerValue - Time.deltaTime;
        if(timerValue <= 0)
        {
            if (isAnsweringQuestion)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true; 
            }
        }
        else
        {
            if (isAnsweringQuestion)
            {
                fillFraction=timerValue/timeToCompleteQuestion;
            }
            else
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
        }
        Debug.Log(timerValue);
    }
    public void CancelTimer()
    {
        timerValue=0;
    }
}
