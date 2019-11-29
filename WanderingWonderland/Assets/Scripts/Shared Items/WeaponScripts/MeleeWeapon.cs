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
        if(other.gameObject.GetComponent<Health>() && ((other.gameObject.transform.root.tag != "Player" && other.gameObject.tag == "Enemy" && gameObject.tag == "PlayerWeapon") 
            || (other.gameObject.transform.root.tag != "Enemy" && other.gameObject.tag == "Player" && gameObject.tag == "EnemyWeapon")))
        {
            other.GetComponent<Health>().TakeDamage(damageValue);
        }
    }

}
