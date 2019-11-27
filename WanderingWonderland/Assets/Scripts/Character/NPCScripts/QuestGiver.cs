using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : NPCController
{
    QuestUIManager QUIM;
    public bool AssignedQuest { get; set; }
    public bool Helped { get; set; } //quest to hand in

    [SerializeField]
    private GameObject quests;
    [SerializeField]
    private string questType;

    public Quest Quest { get; set; }

    void Awake()
    {
        QUIM = FindObjectOfType<QuestUIManager>();

    }
    public override void Interact()
    {
        
        if (!AssignedQuest && !Helped)
        {
            if (QUIM)
               { 
                QUIM.NPCBoxOne.text = "Welcome to Wonderland!";
                QUIM.NPCBoxTwo.text = "Will you please help me out with my quest?";
                }

            AssignQuest();
        }
        else if (AssignedQuest && !Helped)
        {
            CheckQuest();
        }
        else
        {
            if (QUIM)
            {
                QUIM.NPCBoxOne.text = "Welcome to Wonderland!";
                QUIM.NPCBoxTwo.text = "Thanks for all your help again.";
            }

        }

    }

    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));
        Quest.StartText();
    }

    void CheckQuest()
    {
        if(Quest.Completed)
        {
            Quest.GiveReward();
            Helped = true;
            AssignedQuest = false;
            Quest.CompletedText();

        }
        else
        {
            Quest.InprogressText();
        }
    }
}
