using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : Quest
{

    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Risky Rescue";
        Description = "Rescue Buffy the Bandit Basher";
        NPCID = "wood";
        ExperenceReward = 100;
        RequiredAmount = 1;
        CurrentAmount = 0;
        CoinReward = 100;

        Goals.Add(new EscortQuest(this, NPCID, "Rescue Billy Bob from camp", false, CurrentAmount, RequiredAmount, CoinReward));


        Goals.ForEach(g => g.Init());

    }
    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello again Alison,";
            QUIM.NPCBoxTwo.text = "Billy Bob has gone off to attack bandits at a nearby camp and hasn't returned yet...";
        }
        TrackingQuest();
    }

    public override void TrackingQuest()
    {
        if (QUIM)
        {
            QUIM.TextDetails.text = "Rescue Billy Bob from the camp!";
            QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
        }
    }
    public override void InprogressText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Hello Alison";
            QUIM.NPCBoxTwo.text = "Have you found Billy Bob yet?";
        }
    }
    public override void CompletedText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Thank you for your help!";
            QUIM.NPCBoxTwo.text = "Buffy the Bandit Basher is home safe and sound.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
