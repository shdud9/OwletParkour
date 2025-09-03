using System;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public void TurnMusic()
    {
        isTurnedOn = !isTurnedOn;  audioSource.mute = !isTurnedOn;
    }
    public bool isTurnedOn = true;
    public static BackGroundMusic instance;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }
}
