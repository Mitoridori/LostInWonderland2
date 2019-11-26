using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alison : MonoBehaviour
{
    public int maxHitPoints = 5;
    public int baseDamage = 10;
    private CharacterHealth healthBar;
    private int currentHealth;
    private int currentDamage;


    private void Start()
    {
        currentHealth = maxHitPoints;
        currentDamage = baseDamage;

        healthBar = GetComponent<CharacterHealth>();
        if (healthBar)
            healthBar.SetMaxHealth(currentHealth);

    }

    public void DamageInc(int DamgBon)
    {
        currentDamage = currentDamage + DamgBon;
    }

    void ResetDamage()
    {
        currentDamage = baseDamage;
    }


}
