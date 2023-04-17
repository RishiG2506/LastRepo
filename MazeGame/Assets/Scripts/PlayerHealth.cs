using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public float currentHealth;

    public LifeBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.MaxHealth(maxHealth);
    }



    public void Damage(float damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.SetHealth((int)currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        healthBar.SetHealth((int)currentHealth);
    }
}
