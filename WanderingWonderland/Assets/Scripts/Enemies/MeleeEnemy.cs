using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : BaseEnemy
{
    public override void Attack()
    {
        
    }


    public override void Movement()
    {
        if (enemyMovement)
        {
            enemyMovement.RoamingPath();
        } 
        else if((player.transform.position - transform.position).magnitude <= attackRange)
        {
            enemyMovement.GetNavMeshAgent().SetDestination(player.transform.position);
        }
    }

}
