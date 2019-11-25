using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TextDetails;
   

    void Start()
    {
        TextDetails.text = "Quest log is currently empty.";


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TextDetails.text = "s" ; //something grabbing the current text info
    }
}
