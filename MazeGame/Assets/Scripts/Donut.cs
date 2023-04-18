using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour
{
    PlayerHealth playerHealth;
    public void OnTriggerEnter(Collider other)
    {
        playerHealth = other.GetComponent<PlayerHealth>();
        if (15 + playerHealth.currentHealth < playerHealth.maxHealth)
            playerHealth.Damage(-15f);
        else
            playerHealth.Damage(-playerHealth.maxHealth + playerHealth.currentHealth);
        FindObjectOfType<AudioManager>().Play("Item");
        gameObject.SetActive(false);
    }
}
