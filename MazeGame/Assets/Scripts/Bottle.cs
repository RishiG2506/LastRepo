using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public PlayerLocomotion playerLocomotion;
    public void OnTriggerEnter(Collider other)
    {
        playerLocomotion.movementSpeed *= 1.5f;
        FindObjectOfType<AudioManager>().Play("Item");
        gameObject.SetActive(false);
    }
}
