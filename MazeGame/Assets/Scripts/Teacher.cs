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
                FindObjectOfType<AudioManager>().Play("Lock");
                gameObject.SetActive(false);
                playerInventory.leave_count--;
            }
            else FindObjectOfType<AudioManager>().Play("Thud");
        }
    }
}
