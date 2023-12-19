using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject PauseMenuUI;
    public GameObject GameOverScreen;
    public LogicScript logic;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Continue();
            }
            else 
            {
                //Debug.Log("Game Paused");
                Pause();
            }
        }
    }

    void Continue()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    //void GameOver()
    //{
    //    logic.gameOver();
    //    //PauseMenuUI.SetActive(false);
    //    //Time.timeScale = 1f;
    //    //gamePaused = false;
    //}

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void ResumeButton()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
        Debug.Log("Game resumed");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("TitleScreen");
        Debug.Log("Sending you back to Title Screen...");
    }

    // Not Working
    //void GameOver()
    //{
    //    logic.gameOver();
    //    //if (Input.GetKeyDown(KeyCode.Escape))
    //    //{
    //    //    if (gameOverScreen.gameObject.activeInHierarchy == true)
    //    //    {
    //    //        gamePaused = false;
    //    //    } 
    //    //}
    //}
}

