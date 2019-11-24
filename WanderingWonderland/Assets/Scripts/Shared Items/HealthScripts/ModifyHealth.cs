using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyHealth : MonoBehaviour
{
    Health health;
    private int currentHealth;

    private void Start()
    {
        health = GetComponent<Health>();
        currentHealth = health.GetCurrentHealth();
    }

    public void TakeDamage(int amount)
    {
        if(health)
        {
            currentHealth -= amount;
        }
    }

    public void Heal(int amount)
    {
        if (health)
        {
            currentHealth += amount;
        }
    }

}
