using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : BaseWeapon
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Health>())
        {
            healthMod.TakeDamage(damageValue);
        }
    }

}
