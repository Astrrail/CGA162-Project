using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour
{
    public QuestBeginTrigger QBT;
    public float questTimer;
    public float questTimerStartAmount;
    public Text questStartText;
    public Text questTimerText;
    public bool onQuest;
    public GameObject questUI;
    public GameObject[] questEnd;
    public int currentQuest;
    public string[] questCompleteTexts;

    public GameObject exitLevel;

    // Start is called before the first frame update
    void Start()
    {
        questUI.SetActive(false);
        exitLevel.SetActive(false);
        onQuest = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (QBT.startQuestBool == true)
        {
            currentQuest = QBT.questNumber;
            questStartText.text = "Press F to begin quest";
            if (Input.GetKey(KeyCode.F))
            {
                questStartText.text = "GO TO THE SHINY SPOT!";
                questUI.SetActive(true);
                questTimer = questTimerStartAmount;
                onQuest = true;
                QBT.startQuestBool = false;
                questEnd[currentQuest].SetActive(true);

            }
        }
        if (onQuest == true)
        { 
            questTimerText.text = questTimer.ToString();
        questTimer -= Time.deltaTime;
         }
        if (questTimer < 0)
        {
            QuestFail();
        }
    }
    public void QuestFail()
    {
        SceneManager.LoadScene("game scene");
    }
    public void QuestComplete()
    {
        onQuest = false;
        questTimerText.text = questCompleteTexts[currentQuest];
        questEnd[currentQuest].SetActive(false);
        questStartText.text = "";
        exitLevel.SetActive(true);
    }
   
    public void LevelComplete()
    {
        SceneManager.LoadScene(2);
    }
}
