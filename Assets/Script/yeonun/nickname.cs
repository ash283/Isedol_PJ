using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class nickname : MonoBehaviour
{
    public InputField inputfiled;
    public static string filedText;


    private void Update()
    {


        filedText = inputfiled.text;

        if (inputfiled.text.Length < 1)
        {
            filedText = "기메라";
        }
        



    }
}
