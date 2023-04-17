using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collisionInfo.collider.GetComponent<PlayerInventory>();
            if (playerInventory.leave_count>0)
            {
                gameObject.SetActive(false);
                playerInventory.leave_count--;
                //FindObjectOfType<AudioManager>().Play("Lock");
            }
        }
    }
}
