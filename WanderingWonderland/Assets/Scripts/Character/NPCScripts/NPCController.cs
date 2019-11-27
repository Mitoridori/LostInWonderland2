using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//would like to also host the ability for the character to turn and face the NPC without moving towards them, and give a greeting
public class NPCController : MonoBehaviour
{

    public GameObject NPCQuestLog;
    bool NPCClick = false;


    // Start is called before the first frame update
    void Start()
    {
        NPCQuestLog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        InteractMouse();
    }

    //Interactions with NPC
    void QuestGiverMenuOn()
    {
        NPCQuestLog.SetActive(true);
        NPCClick = true;
    }
    public void QuestGiverMenuOff()
    {
        NPCQuestLog.SetActive(false);
        NPCClick = false;
    }

    void InteractMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.tag)
                {
                    case "QuestGiver":
                        if (!NPCClick)
                            QuestGiverMenuOn();
                        else
                            QuestGiverMenuOff();
                        //Debug.Log("Quest giver clicked");
                        break;

                    default:
                        break;

                }
            }

        }

    }
}
