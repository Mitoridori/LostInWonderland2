using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : BaseEnemy
{

    private void Awake()
    {
        ID = "Melee Enemy";
        Experience = 10;
        Coins = 25;
    }

    public override void Attack()
    {
        if ((player.transform.position - transform.position).magnitude <= attackRange)
        {
            enemyMovement.GetNavMeshAgent().SetDestination(player.transform.position);
        }
    }

}
