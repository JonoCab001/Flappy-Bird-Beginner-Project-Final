using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    private bool audioIsOn = false;
    public AudioSource audioSource;

    public void ToggleMute(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = -80;
            Debug.Log("Audio Muted");
        }
        else
        {
            AudioListener.volume = 1;
            Debug.Log("Audio Un-Muted");
        }
    }

    //public void OnButtonPress()
    //{
    //    if (muted == false)
    //    {
    //        muted = true;
    //        AudioListener.pause = true;
    //    }
    //    else
    //    {
    //        muted = false;
    //        AudioListener.pause = false;
    //    }
    //}

    //void Start()
    //{

    //}

    //void Update()
    //{

    //}

    //public void ButtonClicked()
    //{
    //    if (audioIsOn)
    //    {
    //        audioIsOn = false;
    //        audioSource.mute = true;
    //    }
    //    else
    //    {
    //        audioIsOn = true;
    //        audioSource.mute = false;
    //    }
    //}
}
