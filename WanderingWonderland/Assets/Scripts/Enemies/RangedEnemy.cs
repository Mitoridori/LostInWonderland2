using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : BaseEnemy
{

    public override void Attack()
    {
        if (weapon.GetComponent<RangedWeapon>())
        {
            weapon.GetComponent<RangedWeapon>().Attack();
        }
    }

    public override void Movement()
    {
        if(enemyMovement)
        {
            enemyMovement.RoamingPath();
        }
    }
}
