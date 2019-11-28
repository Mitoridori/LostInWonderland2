using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : Quest
{

    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Find Billy";
        Description = "Escort Billy Bob back home";
        NPCID = "wood";
        ExperenceReward = 100;
        RequiredAmount = 1;
        CurrentAmount = 0;
        CoinReward = 100;

        Goals.Add(new EscortQuest(this, NPCID, "Escort Billy back to the village", false, CurrentAmount, RequiredAmount, CoinReward));


        Goals.ForEach(g => g.Init());

    }
    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello again Alison,";
            QUIM.NPCBoxTwo.text = "Billy Bob wondered off and hasn't come home yet, can you find him?...";
        }
        TrackingQuest();
    }

    public override void TrackingQuest()
    {
        if (QUIM)
        {
            QUIM.TextDetails.text = "Find Billy and bring him home!";
            QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
        }
    }
    public override void InprogressText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello Alison";
            QUIM.NPCBoxTwo.text = "Have you found Billy Bob yet? He was always fascinated by that circle of stones north east of here";
        }
    }
    public override void CompletedText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Thank you for your help!";
            QUIM.NPCBoxTwo.text = "Billy is home safe and sound.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
