using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestroyAudio : MonoBehaviour
{
    public static NoDestroyAudio instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(transform.gameObject);
        }
    }
}
