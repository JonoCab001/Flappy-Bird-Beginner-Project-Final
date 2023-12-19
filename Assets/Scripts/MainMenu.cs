using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // PlayGame function will send you to FlappyBirdGame Scene
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    // SettingsButton will send you to the settings scene
    public void SettingsButton()
    {
        SceneManager.LoadScene("SettingsScreen");
    }
}
