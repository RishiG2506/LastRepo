using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore _instance;
    public static PlayerScore Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("PlayerScore");
                go.AddComponent<PlayerScore>();
            }
            return _instance;
        }
    }
    public int score { get; set; }

    public void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void Start()
    {
        score = 0;
    }
    public void AddScore(int points)
    {
        score += points;
    }
    public void ResetScore()
    {
        score = 0;
    }
}
