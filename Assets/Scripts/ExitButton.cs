using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    [SerializeField] GameObject quitConfirm;

    // This will quit the application
    public void ExitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    // Opens up confirmation box
    public void OpenConfirmPrompt()
    {
        quitConfirm.SetActive(true);
        Debug.Log("Message prompt open");
    }

    // Closes confirmation box
    public void CloseConfirmPrompt()
    {
        quitConfirm.SetActive(false);
        Debug.Log("Message prompt closed");
    }
}

