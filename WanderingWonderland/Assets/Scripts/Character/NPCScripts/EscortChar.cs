using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EscortChar : NPCController
{

    private NavMeshAgent agent;
   
    private int movespeed;
    public int speed;
    public Rigidbody rb;
    bool PlayerisNear = false;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Alison);
        Vector3 eulerAngles = transform.rotation.eulerAngles;
        eulerAngles.x = 0;
        eulerAngles.z = 0;
        transform.rotation = Quaternion.Euler(eulerAngles);

        rb.AddRelativeForce(0, 0, movespeed);

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" && !PlayerisNear)
        {
            speedup();
            PlayerisNear = true;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        movespeed = 0;
        PlayerisNear = false;
    }

    public void speedup()
    {
        movespeed = speed;
    }

    public override void Interact()
    {

    }



}
