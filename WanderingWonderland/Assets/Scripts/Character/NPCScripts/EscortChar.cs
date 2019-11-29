using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EscortChar : NPCController
{

    private NavMeshAgent agent;
    public int followRange = 5;
   


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

    }
    private void FixedUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if ((Alison.transform.position - transform.position).magnitude <= followRange)
        {
           agent.SetDestination(Alison.transform.position);
        }
    }


    public override void Interact()
    {

    }



}
