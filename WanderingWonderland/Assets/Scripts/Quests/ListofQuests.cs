using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListofQuests : MonoBehaviour
{
    //Quest Information
    public List<GameObject> QuestList;
    int index;
    bool gameIsWon = false;






    // Start is called before the first frame update
    void Start()
    {
        if (QuestList.Count != 0)
        {
            QuestList[0].SetActive(true);
            index = 0;
        }
    }

    private void Update()
    {
        if (QuestList.Count != 0)
        {
            SwitchPhase();
        }
    }

    void SwitchPhase()
    {
        if (gameIsWon == false)
        {
            switch (QuestList[index].activeInHierarchy)
            {
                case true:
                    break;

                case false:
                    IncremementIndex();
                    QuestList[index].SetActive(true);
                    break;

                default:
                    break;
            }
        }
        else
        {
            GameOver();
        }
    }
    void IncremementIndex()
    {
        if (index < QuestList.Count - 1)
        {
            index++;
        }
        else if (index == QuestList.Count - 1)
        {
            gameIsWon = true;
            return;
        }
    }
    //All quests are finished
    void GameOver()
    {
        if (gameIsWon)
        {
            //what to do when game is over.
        }
    }
}
