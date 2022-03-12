using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_PhoneImg : MonoBehaviour
{
    public GameObject ButtonGroup;
    public GameObject InfoGroup;
    //bool isButtonOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isButtonOn = ButtonGroup.GetComponent<SC_Phone>().isClick;
        Text text = ButtonGroup.GetComponent<SC_Phone>().SelText;
        if (isButtonOn)
        {
            //Debug.Log(1);
            gameObject.GetComponent<Animation>().Play();
            ButtonGroup.GetComponent<SC_Phone>().isClick = false;

            //InfoGroup.transform.GetChild(3).GetComponent<Text>().text = text.text;

            InfoGroup.SetActive(true);
        }
    }
}
