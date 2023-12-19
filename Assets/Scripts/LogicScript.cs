using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public int playerHighScore = 0;
    public static bool gamePaused = false;
    public Text scoreText;
    public Text playerHighScoreText;
    public GameObject GameOverScreen;
    public AudioSource audioClip;

    // This is to add points after the player have gone through each pipe hence the pipe will add the player's score
    [ContextMenu ("Increase Score")]
    public void addScore(int scoreToAdd)
    { 
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        audioClip.Play();
        Debug.Log(scoreText);
    }

    // This is to restart the game after game over
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    // This will exit the game and return to the title screen
    public void exitGame()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);

        // This is to log the player's score to see how much points they get
        if (playerScore > playerHighScore)
        {
            playerHighScore = playerScore;
            PlayerPrefs.SetInt("highScore", playerScore);
            playerHighScoreText.text = "High Score: " + playerScore.ToString();
            Time.timeScale = 1f;
        }

        Time.timeScale = 0f;
    }

    // Not Working
    //void Update()
    //{
    //    if (GameOverScreen.gameObject.activeInHierarchy == true)
    //    {
    //        gamePaused = false;
    //    }
    //}
}
