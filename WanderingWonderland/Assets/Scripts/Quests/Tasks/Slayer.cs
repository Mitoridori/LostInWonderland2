﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slayer : Quest
{

    private void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

        QuestName = "Monster Masher";
        Description = "Defeat the final boss";
        NPCID = "wood";
        ExperenceReward = 100;
        RequiredAmount = 1;
        CurrentAmount = 0;
        CoinReward = 100;

        Goals.Add(new KillQuest(this, NPCID, "Kill " + RequiredAmount + " Beast", false, CurrentAmount, RequiredAmount, CoinReward));


        Goals.ForEach(g => g.Init());

    }

    public override void StartText()
    {
        if (QUIM)
        {
            QUIM.NPCBoxOne.text = "Welcome Alison,";
            QUIM.NPCBoxTwo.text = "we are having issues with a large beast, can you slay it for us?";
        }
        TrackingQuest();
    }

    public override void TrackingQuest()
    {
        if (QUIM)
        {
            QUIM.TextDetails.text = "Slay the giant beast hanging around the circle of stones";
            QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
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
            QUIM.NPCBoxTwo.text = "You have saved our village.";
            QUIM.TextDetails.text = "No Current Quest";
            QUIM.TextTally.text = "  ";
        }
    }
}
