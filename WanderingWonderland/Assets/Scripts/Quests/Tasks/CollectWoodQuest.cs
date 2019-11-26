using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWoodQuest : QuestParent
{
    GameObject wood;
    
    // Start is called before the first frame update
    void Awake()
    {
        //get list of all items in the scene to be collected
        CountItems(wood);
        TotalItems = QuestItems.Length;



        //make sure all objects are inactive

    }

    // Update is called once per frame
    void Update()
    {
        //check if quest is active
        //if not break
        //if active check to see what has been collected vs what hasn't
        //display the proper quest information in the quest box, task and x/x 
        //check to see if all items collected
        //if so tell player quest is over
        //if not continue on quest
    }

    public override void QuestInstuctions()
    {
        QuestInstructionsText = "Our village is running short on wood, but the bandits make it hard to get it, can you please gather it for us.";
    }
    public override void QuestTracking()
    {
        QuestTrackingText = CollectedItems + " / " + TotalItems;
    }
    public override void QuestReturn()
    {
        QuestReturnText = "Return to the NPC to get your reward";
    }



}
