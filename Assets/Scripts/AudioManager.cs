﻿using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else 
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
