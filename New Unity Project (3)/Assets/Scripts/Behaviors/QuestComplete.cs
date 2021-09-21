using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestComplete : MonoBehaviour
{
    public QuestManager QM;

    void OnTriggerEnter(Collider other)
    {
        QM.QuestComplete();
    }
}
