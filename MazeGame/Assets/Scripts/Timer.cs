using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currTime;
    public int redTime;
    public int totalTime;


    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;

        var ts = TimeSpan.FromSeconds(currTime);
        timerText.text = string.Format("{0:00}:{1:00}", (int)ts.TotalMinutes, (int)ts.Seconds);

        if ((int)currTime > redTime)
        {
            timerText.color = Color.red;
        }
        if ((int)currTime >= totalTime)
        {
            timerText.SetText("Whoops, Time Over!");
            Invoke("PrevLevel", 1);
        }  
    }

    void PrevLevel()
    {
        if (PlayerScore.Instance.score <= 2000)
        {
            PlayerScore.Instance.ResetScore();
        }
        else
            PlayerScore.Instance.AddScore(-2000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
