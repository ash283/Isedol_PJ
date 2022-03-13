using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public enum AUDIO
    {
        FX_ALARM
    }

    [SerializeField]
    SerializableDictionary<AUDIO, AudioClip> audios;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audios.init();
    }

    public void playAudio(AUDIO audio)
    {
        audioSource.clip = audios.get(audio);
        audioSource.Play();
    }

    public void stopSound()
    {
        audioSource.Stop();
    }
}
