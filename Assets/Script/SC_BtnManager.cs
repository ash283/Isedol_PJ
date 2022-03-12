using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_BtnManager : MonoBehaviour
{
    public GameObject Load_Panel;
    public GameObject CG_Panel;
    public GameObject Option_Panel;
    // Start is called before the first frame update
    void Start()
    {
        //Screen.SetResolution(1920, 1080, true, 60);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameLoadwindow()
    {
        Load_Panel.SetActive(true);
    }
    public void ExitLoadWindow()
    {
        Load_Panel.SetActive(false);
    }
    public void GameCGwindow()
    {
        CG_Panel.SetActive(true);
    }
    public void ExitCGWindow()
    {
        CG_Panel.SetActive(false);
    }
    public void Optionwindow()
    {
        Option_Panel.SetActive(true);
    }
    public void ExitOptionWindow()
    {
        Option_Panel.SetActive(false);
    }
    public void ExitGameWindow()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("nickname");
    }

}

