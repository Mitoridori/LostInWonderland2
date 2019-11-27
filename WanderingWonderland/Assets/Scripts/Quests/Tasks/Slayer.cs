using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slayer : Quest
{

    private void Start()
    {
        QuestName = "Ultimate Slayer";
        Description = "Kill a bunch of stuff";
        //ItemReward = ItemDataBase.Instance.GetItem("potion_log");
        ExperenceRewart = 100;

        Goals.Add(new BanditQuest(this, 0, "Kill 5 Slimes", false, 0, 5));
        Goals.Add(new BanditQuest(this, 1, "Kill 2 vampires", false, 0, 2));

        Goals.ForEach(g => g.Init());

    }
}
