using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyHealth : MonoBehaviour
{
    Health health;

    private void Start()
    {
        health = GetComponent<Health>();
    }

    public void TakeDamage(int amount)
    {
        if(health)
        {

        }
    }

    public void HealCharacter(int amount)
    {
        if (health)
        {

        }
    }

}
