using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scene : MonoBehaviour
{
    public AudioSource myaudio;


    public int load;
    public Text text;
    public int game;
    public GameObject gameObject;


    private void Start()
    {
        myaudio = GetComponent<AudioSource>();
    }


    public void scenemove()
    {
        gameObject.SetActive(true);
    }


    public void ingamemove()
    {
        SceneManager.LoadScene("ingame");
    }

    public void returnback()
    {

        gameObject.SetActive(false);

    }
    public void clickstart()
    {
        game = 1;
    }
    
    public void saveandload()
    {
        
        load = GameObject.FindWithTag("text").GetComponent<TestMessage>().chapter;
       
        
        PlayerPrefs.SetInt("chapter", load);
        PlayerPrefs.Save();


    }



}
