using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : BaseWeapon
{

    public override void Attack()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Health>())
        {
            other.GetComponent<Health>().TakeDamage(damageValue);
        }
    }

}
