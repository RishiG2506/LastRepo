using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalLeave : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if (playerInventory != null)
        {
            playerInventory.collectLeave();
            gameObject.SetActive(false);
            //FindObjectOfType<AudioManager>().Play("Item");
        }
        PlayerScore.Instance.AddScore(500);
    }
}
