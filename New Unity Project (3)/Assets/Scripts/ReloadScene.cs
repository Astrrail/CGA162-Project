using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    //Eventuall will have pop up screen with options to reload or do other things
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("game scene");
    }
}