using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public abstract class Quest : MonoBehaviour
{
    public QuestUIManager QUIM;

    public List<QuestGoal> Goals = new List<QuestGoal>();
    public string QuestName;
    public string Description;
    public int ExperenceReward;  
    public bool Completed;
    protected int RequiredAmount;
    protected int CurrentAmount;


    public abstract void StartText();
    public abstract void InprogressText();
    public abstract void CompletedText();
    void Start()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

    }
    public void CheckGoals()
    {
        Completed = Goals.All(g => g.Completed);
        //can change dilog here is wanted
    }

    public void GiveReward()
    {
        //if (ItemReward != null)
        //    InventoryController.Instance.GiveItem(ItemReward);
    }

    

}
