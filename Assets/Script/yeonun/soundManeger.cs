using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManeger : MonoBehaviour
{
    public AudioSource musicsource;

    
    
    public AudioClip audioalarm;
    



    AudioSource audioSource;



    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    public void SetMusicVolume(float volume)
    {
        
        musicsource.volume = volume;
    }

}
