using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscortQuest : QuestGoal
{

    public string EnemyID { get; set; }

    public EscortQuest(Quest quest, string enemyID, string description, bool completed, int currentAmount, int requiredAmount, int coins)
    {
        this.Quest = quest;
        this.EnemyID = enemyID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
        this.CoinReward = coins;
    }


    
}
