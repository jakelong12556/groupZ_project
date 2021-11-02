using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    void Start()
    {
        // Set player current health to max health
        currentHealth = maxHealth;

        // Set health bar to max health
        healthBar.SetMaxHealth(maxHealth); 
    }

    void Update()
    {
        // Testing
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Debug.Log("Space key was pressed.");
            TakeDamage(5);
        }
    }

    // If player has been hit, decrease player health
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
