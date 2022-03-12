using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class namecheck : MonoBehaviour
{
    public Text text;


    private void Awake()
    {
        text.text = "당신의  이름이 " + nickname.filedText + "이(가) 맞나요?";
    }

}
