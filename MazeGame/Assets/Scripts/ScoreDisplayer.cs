using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    public void Awake()
    {
        scoreDisplay = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    public void Update()
    {
        scoreDisplay.color = Color.cyan;
        scoreDisplay.text = string.Format("<b>Score: {0}</b>", PlayerScore.Instance.score);
    }
}
