using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public GameObject pausePanel;
    public bool gamePaused;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePaused)
            {
                Continue();
            }
            else
            {
                Debug.Log("Game Paused");
                Pause();
            }
        }  
    }
    
    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }
}
