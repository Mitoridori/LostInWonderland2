using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestParent : MonoBehaviour
{

    public bool QuestCompleted; //Objectives completed
    public bool QuestFinished; //Quest Handed In
    protected int TotalItems;
    protected int CollectedItems;
    public GameObject[] QuestItems;
    public string QuestInstructionsText;
    public string QuestTrackingText;
    public string QuestReturnText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void QuestInstuctions();
    public abstract void QuestTracking();
    public abstract void QuestReturn();

    public void CountItems(GameObject Item)
    {
        for (int i = 0; i < QuestItems.Length; i++)
        {
            QuestItems[i] = Item;
        }
    }
}
