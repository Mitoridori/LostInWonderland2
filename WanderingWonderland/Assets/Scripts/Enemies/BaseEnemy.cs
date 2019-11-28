using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour, IQuestID
{

    public string ID {get; set;}
    public int Experience { get; set; }
    public int Coins { get; set; }

    public float attackSpeed = 3f;
    public GameObject weapon;
    public int attackRange;
    protected EnemyRoaming enemyMovement;

    protected CharController player;
    Health health;
    float nextAttack;
    float turnSpeed = 1.0f;
    float singleStep;


    private enum EnemyStates
    {
        waiting,
        roaming,
        attacking,
        dead
    }

    private EnemyStates state = EnemyStates.waiting;

    public abstract void Attack();

    public abstract void Movement();

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharController>();
        health = GetComponent<Health>();
        enemyMovement = GetComponent<EnemyRoaming>();
        nextAttack = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateEnemy();
    }

    void UpdateEnemy()
    {
        CheckCurrentHealth();
        if (state != EnemyStates.dead)
        {
            switch (state)
            {
                case EnemyStates.waiting:
                    CheckIfActive();
                    break;
                case EnemyStates.attacking:
                    CheckIfCanAttack();
                    StopAttacking();
                    break;
                case EnemyStates.roaming:
                    FindTarget(attackRange);
                    Movement();
                    break;

                default:
                    break;
            }
            
            if(state == EnemyStates.attacking)
            {
                RotateEnemy();
            }
        }
        else if (state == EnemyStates.dead)
        {
            Done();
            gameObject.SetActive(false);
        }
    }

    void CheckIfActive()
    {
        if(gameObject.activeInHierarchy && state != EnemyStates.roaming)
        {
            state = EnemyStates.roaming;
        }
    }

    void CheckIfCanAttack()
    {
        if(state == EnemyStates.attacking)
        {
            if (Time.time > nextAttack)
            {
                nextAttack = (Time.time + attackSpeed);
                Attack();
            }
        }
    }

    void CheckCurrentHealth()
    {
        if(health.GetCurrentHealth() <= 0)
        {
            state = EnemyStates.dead;
        }
    }

    void StopAttacking()
    {
        if (Vector2.Distance(transform.position, player.transform.position) > attackRange)
        {
            state = EnemyStates.roaming;
        }
    }

    public void RotateEnemy()
    {
        Vector3 targetDirection = player.transform.position - transform.position;
        singleStep = turnSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    void FindTarget(float range)
    {
        if (player)
        {
            if (Vector2.Distance(transform.position, player.transform.position) <= range)
            {
                state = EnemyStates.attacking;
                CheckIfCanAttack();
            }
        }
    }

    public void Done()
    {
        QuestEvents.EnemyDied(this);
    }
}
