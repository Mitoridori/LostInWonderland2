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

    ListofQuests QuestNPC;


    void Start()
    {
        
       NoQuestFound();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {


    }

    void NoQuestFound()
    {
        TextDetails.text = "Quest log is currently empty.";
        TextTally.text = " ";
        NPCBoxOne.text = "Welcome Alison";
        NPCBoxTwo.text = "Thank you for your help.";
    }
}
