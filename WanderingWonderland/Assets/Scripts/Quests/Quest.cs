using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Quest : MonoBehaviour
{
    public List<QuestGoal> Goals { get; set; } = new List<QuestGoal>();
    public string QuestName { get; set; }
    public string Description { get; set; }
    public int ExperenceRewart { get; set; }
    //public Item ItemRewart { get; set; }
    public bool Completed { get; set; }

    public void CheckGoals()
    {
        Completed = Goals.All(g => g.Completed);
        //can change dilog here is wanted
    }

    private void GiveReward()
    {
        //if (ItemReward != null)
        //    InventoryController.Instance.GiveItem(ItemReward);
    }

}
