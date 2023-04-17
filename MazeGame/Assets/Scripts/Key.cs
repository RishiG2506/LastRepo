using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if(playerInventory != null)
        {
            playerInventory.setKey();
            gameObject.SetActive(false);
            //FindObjectOfType<AudioManager>().Play("Item");
        }
        PlayerScore.Instance.AddScore(1000);
    }
}
