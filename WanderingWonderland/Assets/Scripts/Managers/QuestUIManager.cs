using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TextDetails;
    public TextMeshProUGUI TextTally;
    public TextMeshProUGUI NPCBoxOne;
    public TextMeshProUGUI NPCBoxTwo;

    QuestGiver QG;

    void Start()
    {
        QG = FindObjectOfType<QuestGiver>();

       NoQuestFound();
    }

    // Update is called once per frame
    void Update()
    {
        if (QG && QG.AssignedQuest)
            QG.Quest.TrackingQuest();
        else
            NoQuestFound();
    }
    
    void NoQuestFound()
    {
        TextDetails.text = "Quest log is currently empty.";
        TextTally.text = " ";
        NPCBoxOne.text = "Welcome Alison";
        NPCBoxTwo.text = "Thank you for your help.";
    }
}
