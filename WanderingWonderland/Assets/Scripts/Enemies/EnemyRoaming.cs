using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRoaming : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform WaypointContainer;
    public Transform[] waypoints;
    private int currentWaypoint = 0;
    public float distanceToCover = 1f;

    private float[] distanceLeftToTravel;



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GetWaypoints();
        distanceLeftToTravel = new float[waypoints.Length];
    }

    public void RoamingPath()
    {
        for (int i = 0; i < waypoints.Length; i++)
        {
            Transform nextWaypoint = GetCurrentWaypoint();
            float distanceCovered = (nextWaypoint.position - transform.position).magnitude;

            if (distanceLeftToTravel[i] - distanceToCover > distanceCovered ||
                waypoints[i] != nextWaypoint)
            {
                waypoints[i] = nextWaypoint;
                distanceLeftToTravel[i] = distanceCovered;
            }
            agent.SetDestination(nextWaypoint.position);
        }
    }

    void GetWaypoints()
    {
        Transform[] potentialWaypoints = WaypointContainer.GetComponentsInChildren<Transform>();
        waypoints = new Transform[(potentialWaypoints.Length - 1)];

        for (int i = 1; i < potentialWaypoints.Length; i++)
        {
            waypoints[i - 1] = potentialWaypoints[i];
        }
    }


    public Transform GetCurrentWaypoint()
    {
        return waypoints[currentWaypoint];
    }

}
