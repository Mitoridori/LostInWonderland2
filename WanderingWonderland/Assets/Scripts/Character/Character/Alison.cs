using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alison : MonoBehaviour
{
    public int maxHitPoints = 5;
    private CharacterHealth healthBar;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHitPoints;

        healthBar = GetComponent<CharacterHealth>();
        if (healthBar)
            healthBar.SetMaxHealth(currentHealth);

    }




}
