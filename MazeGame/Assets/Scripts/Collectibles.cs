using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    PlayerInventory playerInventory;
    public TextMeshProUGUI key;
    void Awake()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInventory.collectedKey) {
            key.text = "<b>COLLECTED!</b>";
        }
        else
        {

            key.text = "?";
        }
    }
}
