using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    public Timer timer;
    public void OnTriggerEnter(Collider other)
    {
        if (timer.currTime >= 10f)
            timer.currTime -= 10f;
        else timer.currTime = 0f;
        FindObjectOfType<AudioManager>().Play("Item");
        gameObject.SetActive(false);
            
    }
}
