using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alison : MonoBehaviour
{
    public int maxHitPoints = 5;
    public int baseDamage = 10;
    public CharController CC;
    private CharacterHealth healthBar;
    private int currentHealth;
    private int currentDamage;
    private float BaseRunSpeed;


    private void Start()
    {
        currentHealth = maxHitPoints;
        currentDamage = baseDamage;
        CC = GetComponent<CharController>();
        if (CC)
        {
            BaseRunSpeed = CC.runSpeed;
        }
        healthBar = GetComponent<CharacterHealth>();
        if (healthBar)
            healthBar.SetMaxHealth(currentHealth);

    }

    public void DamageInc(int amount)
    {
        currentDamage += amount;
        print(currentDamage);
    }

    public void ResetDamage()
    {
        currentDamage = baseDamage;
    }
    public void IncreaseSpeed(int amount)
    {
        CC.runSpeed += amount;
    }
    public void ResetSpeed()
    {
        CC.runSpeed = BaseRunSpeed;
    }

}
