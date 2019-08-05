using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuBehavior : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    CharacterController controller;

    public void ResumeButtonBehavior()
    {
        if(Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }

        pauseMenu.SetActive(false);
        
    }

    public void ExitButtonBehavior()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }

        SceneManager.LoadScene("TitleScreen");
        pauseMenu.SetActive(false);
    }

    public void GameOverRetryButtonBehavior()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }

        SceneManager.LoadScene("Battleground");
        gameOverMenu.SetActive(false);   
    }

    public void GameOverExitButtonBehavior()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }

        SceneManager.LoadScene("TitleScreen");
        gameOverMenu.SetActive(false);
    }
}
