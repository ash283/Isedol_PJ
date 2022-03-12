using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_BtnChar : MonoBehaviour
{
    public int MemberNum;
    public GameObject Ine;
    public GameObject Jingburger;
    public GameObject Lilpa;
    public GameObject Jururu;
    public GameObject Gosegu;
    public GameObject Vichan;

    public Sprite ChoiceImg;
    public Sprite StayImg;

    // Start is called before the first frame update
    void Start()
    {
        Image IneImgButton = Ine.GetComponent<Image>();
        Image JingImgButton = Jingburger.GetComponent<Image>();
        Image LilImgButton = Lilpa.GetComponent<Image>();
        Image JuImgButton = Jururu.GetComponent<Image>();
        Image GoImgButton = Gosegu.GetComponent<Image>();
        Image ViImgButton = Vichan.GetComponent<Image>();

        IneImgButton.alphaHitTestMinimumThreshold = 0.1f;
        JingImgButton.alphaHitTestMinimumThreshold = 0.1f;
        LilImgButton.alphaHitTestMinimumThreshold = 0.1f;
        JuImgButton.alphaHitTestMinimumThreshold = 0.1f;
        GoImgButton.alphaHitTestMinimumThreshold = 0.1f;
        ViImgButton.alphaHitTestMinimumThreshold = 0.1f;
        MemberNum = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void IneWindow()
    {
        MemberNum = 0;
        Ine.GetComponent<Image>().sprite = ChoiceImg;
        Ine.transform.SetAsLastSibling();
        TextChanger();

        Jingburger.GetComponent<Image>().sprite = StayImg;
        Lilpa.GetComponent<Image>().sprite = StayImg;
        Jururu.GetComponent<Image>().sprite = StayImg;
        Gosegu.GetComponent<Image>().sprite = StayImg;
        Vichan.GetComponent<Image>().sprite = StayImg;
    }
    public void JingburgerWindow()
    {
        MemberNum = 1;
        Jingburger.GetComponent<Image>().sprite = ChoiceImg;
        Jingburger.transform.SetAsLastSibling();
        TextChanger();

        Ine.GetComponent<Image>().sprite = StayImg;        
        Lilpa.GetComponent<Image>().sprite = StayImg;
        Jururu.GetComponent<Image>().sprite = StayImg;
        Gosegu.GetComponent<Image>().sprite = StayImg;
        Vichan.GetComponent<Image>().sprite = StayImg;
    }
    public void LilpaWindow()
    {
        MemberNum = 2;
        Lilpa.GetComponent<Image>().sprite = ChoiceImg;
        Lilpa.transform.SetAsLastSibling();
        TextChanger();

        Ine.GetComponent<Image>().sprite = StayImg;
        Jingburger.GetComponent<Image>().sprite = StayImg;
        Jururu.GetComponent<Image>().sprite = StayImg;
        Gosegu.GetComponent<Image>().sprite = StayImg;
        Vichan.GetComponent<Image>().sprite = StayImg;
    }
    public void JururuWindow()
    {
        MemberNum = 3;
        Jururu.GetComponent<Image>().sprite = ChoiceImg;
        Jururu.transform.SetAsLastSibling();
        TextChanger();

        Ine.GetComponent<Image>().sprite = StayImg;
        Jingburger.GetComponent<Image>().sprite = StayImg;
        Lilpa.GetComponent<Image>().sprite = StayImg;
        Gosegu.GetComponent<Image>().sprite = StayImg;
        Vichan.GetComponent<Image>().sprite = StayImg;
    }
    public void GoseguWindow()
    {
        MemberNum = 4;
        Gosegu.GetComponent<Image>().sprite = ChoiceImg;
        Gosegu.transform.SetAsLastSibling();
        TextChanger();

        Ine.GetComponent<Image>().sprite = StayImg;
        Jingburger.GetComponent<Image>().sprite = StayImg;
        Lilpa.GetComponent<Image>().sprite = StayImg;
        Jururu.GetComponent<Image>().sprite = StayImg;        
        Vichan.GetComponent<Image>().sprite = StayImg;
    }
    public void ViichanWindow()
    {
        MemberNum = 5;
        Vichan.GetComponent<Image>().sprite = ChoiceImg;
        Vichan.transform.SetAsLastSibling();
        TextChanger();

        Ine.GetComponent<Image>().sprite = StayImg;
        Jingburger.GetComponent<Image>().sprite = StayImg;
        Lilpa.GetComponent<Image>().sprite = StayImg;
        Jururu.GetComponent<Image>().sprite = StayImg;
        Gosegu.GetComponent<Image>().sprite = StayImg;        
    }

    void TextChanger()
    {
        Ine.transform.GetChild(0).GetComponent<Text>().fontSize = 35;
        Jingburger.transform.GetChild(0).GetComponent<Text>().fontSize = 35;
        Lilpa.transform.GetChild(0).GetComponent<Text>().fontSize = 35;
        Jururu.transform.GetChild(0).GetComponent<Text>().fontSize = 35;
        Gosegu.transform.GetChild(0).GetComponent<Text>().fontSize = 35;
        Vichan.transform.GetChild(0).GetComponent<Text>().fontSize = 35;

        switch(MemberNum)
        {
            case 0:
                Ine.transform.GetChild(0).GetComponent<Text>().fontSize = 40;
                break;
            case 1:
                Jingburger.transform.GetChild(0).GetComponent<Text>().fontSize = 40;
                break;
            case 2:
                Lilpa.transform.GetChild(0).GetComponent<Text>().fontSize = 40;
                break;
            case 3:
                Jururu.transform.GetChild(0).GetComponent<Text>().fontSize = 40;
                break;
            case 4:
                Gosegu.transform.GetChild(0).GetComponent<Text>().fontSize = 40;
                break;
            case 5:
                Vichan.transform.GetChild(0).GetComponent<Text>().fontSize = 40;
                break;
        }
    }
}
