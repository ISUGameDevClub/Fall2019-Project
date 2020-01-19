using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script is attached to the PauseMenuUI Prefab, which should be attached to the Pause Menu Prefab.
//To create a Pause Menu, just drag the Pause Menu Prefab to the hierarchy.
public class PauseMenuUI : MonoBehaviour
{
    public void OpenPauseMenu()
    {
        gameObject.SetActive(true); //gameObject refers to the GameObject that the script is attached to.
        Time.timeScale = 0f; //Stop unity engine time; Pauses game functions.
    }

    public void ClosePauseMenu()
    {
        gameObject.SetActive(false); //Sets pause menu UI to be invisible.
        Time.timeScale = 1f; //Resumes unity game functions.
    }
}
