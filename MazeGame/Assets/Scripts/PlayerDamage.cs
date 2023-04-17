using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth playerHealth;
    Rigidbody rigidBody;
    Transform transform;
    PlayerInventory playerInventory;
    public void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
        rigidBody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        playerInventory = GetComponent<PlayerInventory>();
    }
    public void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.CompareTag("Teacher"))
        {
            if (playerInventory.leave_count == 0)
            {
                rigidBody.AddForce(-transform.forward * 80, ForceMode.Impulse);
                playerHealth.Damage(20);
            }
        }
    }
}
