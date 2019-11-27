using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : NPCController
{
    public bool AssignedQuest { get; set; }
    public bool Helped { get; set; } //quest to hand in

    [SerializeField]
    private GameObject quests;
    [SerializeField]
    private string questType;

    public Quest Quest { get; set; }

    public override void Interact()
    {
        
        if (!AssignedQuest && !Helped)
        {

            AssignQuest();
        }
        else if (AssignedQuest && !Helped)
        {
            CheckQuest();
        }
        else
        {
            //DialogueSystem.Instance.AddNewDialog(new string[] { "Thanks for that!" }, name);
        }

    }

    void AssignQuest()
    {
        AssignedQuest = true;
        Quest = (Quest)quests.AddComponent(System.Type.GetType(questType));
    }

    void CheckQuest()
    {
        if(Quest.Completed)
        {
            Quest.GiveReward();
            Helped = true;
            AssignedQuest = false;

            //DialogueSystem.Instance.AddNewDialog(new string[] { "Thanks for that! here's your reward." }, name);
        }
        else
        {
            //DialogueSystem.Instance.AddNewDialog(new string[] { "Your not done yet!" }, name);
        }
    }
}
