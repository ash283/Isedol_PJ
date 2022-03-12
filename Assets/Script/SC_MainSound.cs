using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SC_MainSound : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("MainBGMVol", Mathf.Log10(sliderValue) * 20);
    }
    private void Awake()
    {
        slider.value = 0.5f;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void PlaySound()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            mixer.SetFloat("MainBGMVol", -80);
        }
    }
}
