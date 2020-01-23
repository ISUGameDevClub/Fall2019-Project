using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    [SerializeField]
    private PauseMenuUI pauseMenuUI = null;

    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        //pauseMenuUI = GameObject.FindGameObjectWithTag("Pause Menu UI").GetComponent<PauseMenuUI>(); //How do I get this working?
        //Debug.Log("Test start!");
        //Debug.Log(pauseMenuUIObject);
        //Debug.Log("Test finish!");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)//If game already paused.
            {
                ResumeGame();
            }
            else //Game is not already pasued.
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.ClosePauseMenu();
        gameIsPaused = false;
        //audioData.UnPause();
        audioData.pitch = 1f;
    }

    void PauseGame()
    {
        pauseMenuUI.OpenPauseMenu();
        gameIsPaused = true;
        //audioData.Pause();
        audioData.pitch = 0.5f;
    }

    public void LoadMainMenu()
    {
        //To-Do
        Debug.Log("Loading main menu...");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting game...");
        Application.Quit();

    }
}
