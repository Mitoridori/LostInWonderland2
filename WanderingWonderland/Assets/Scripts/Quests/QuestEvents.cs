using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEvents : MonoBehaviour
{
    public delegate void EnemyEventHandler(IQuestID enemy);
    public static event EnemyEventHandler OnEnemyDeath;

    public static void EnemyDied(IQuestID enemy)
    {
        if (OnEnemyDeath != null)
            OnEnemyDeath(enemy);
    }
}
