using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBeginTrigger : MonoBehaviour
{
    public bool startQuestBool;
    public int questNumber;

    // Start is called before the first frame update
    void Start()
    {
        startQuestBool = false;  
    }
    
    private void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        startQuestBool = true;
    }

    void OnTriggerExit(Collider other)
    {
        startQuestBool = false;
    }
}
