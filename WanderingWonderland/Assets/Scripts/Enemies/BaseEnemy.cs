using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    public int attackSpeed;
    public int attackRange;

    CharController player;
    Health health;


    private enum EnemyStates
    {
        waiting,
        roaming,
        attacking,
        dead
    }

    private EnemyStates state = EnemyStates.waiting;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharController>();
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
