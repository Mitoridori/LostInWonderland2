using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slayer : Quest
{

    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Ultimate Slayer";
        Description = "Kill a bunch of stuff";
        ExperenceReward = 100;
        RequiredAmount = 1;
        CurrentAmount = 0;

        Goals.Add(new KillQuest(this, 0, "Kill " + RequiredAmount + " Beast", false, CurrentAmount, RequiredAmount));
        //Goals.Add(new KillQuest(this, 1, "Kill 2 vampires", false, 0, 2));

        Goals.ForEach(g => g.Init());

    }

    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Welcome Alison,";
            QUIM.NPCBoxTwo.text = "we are having issues with a large beast, can you slay it for us?";
            QUIM.TextDetails.text = "Slay" + RequiredAmount + "Beast";
            QUIM.TextTally.text = CurrentAmount + " / " + RequiredAmount ;
        }
    }
    public override void InprogressText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello Alison";
            QUIM.NPCBoxTwo.text = "Have you had any luck hunting down the beast?";
        }
    }
    public override void CompletedText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Thank you for your help!";
            QUIM.NPCBoxTwo.text = "We shall never be bothered by them again.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
