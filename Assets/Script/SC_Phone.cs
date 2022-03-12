using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_Phone : MonoBehaviour
{
    public Sprite NorPicture;
    public Sprite NorArrow;
    public Sprite SelPicture;
    public Sprite SelArrow;
    public Text SelText;

    Image charPicture0;
    Image arrowImg0;
    Image charPicture1;
    Image arrowImg1;
    Image charPicture2;
    Image arrowImg2;
    Image charPicture3;
    Image arrowImg3;
    Image charPicture4;
    Image arrowImg4;
    Image charPicture5;
    Image arrowImg5;

    public bool isClick = false;    
    // Start is called before the first frame update
    void Start()
    {
        charPicture0 = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Image>();
        arrowImg0 = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).GetComponent<Image>();
        charPicture1 = gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).GetComponent<Image>();
        arrowImg1 = gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).GetComponent<Image>();
        charPicture2 = gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).GetComponent<Image>();
        arrowImg2 = gameObject.transform.GetChild(2).gameObject.transform.GetChild(1).GetComponent<Image>();
        charPicture3 = gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).GetComponent<Image>();
        arrowImg3 = gameObject.transform.GetChild(3).gameObject.transform.GetChild(1).GetComponent<Image>();
        charPicture4 = gameObject.transform.GetChild(4).gameObject.transform.GetChild(0).GetComponent<Image>();
        arrowImg4 = gameObject.transform.GetChild(4).gameObject.transform.GetChild(1).GetComponent<Image>();
        charPicture5 = gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).GetComponent<Image>();
        arrowImg5 = gameObject.transform.GetChild(5).gameObject.transform.GetChild(1).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IneClick()
    {
        InitClick();
        charPicture0.sprite = SelPicture;
        arrowImg0.sprite = SelArrow;
        isClick = true;
        SelText.text = "아이네";
     }
    public void JingBurgerClick()
    {
        InitClick();
      
        charPicture1.sprite = SelPicture;
        arrowImg1.sprite = SelArrow;
        isClick = true;
        SelText.text = "징버거";
    }
    public void LilpaClick()
    {
        InitClick();

        charPicture2.sprite = SelPicture;
        arrowImg2.sprite = SelArrow;
        isClick = true;
        SelText.text = "릴파";
    }
    public void JururuClick()
    {
        InitClick();

        charPicture3.sprite = SelPicture;
        arrowImg3.sprite = SelArrow;
        isClick = true;
        SelText.text = "주르르";
    }
    public void GoseguClick()
    {
        InitClick();

        charPicture4.sprite = SelPicture;
        arrowImg4.sprite = SelArrow;
        isClick = true;
        SelText.text = "고세구";
    }
    public void ViichanClick()
    {
        InitClick();

        charPicture5.sprite = SelPicture;
        arrowImg5.sprite = SelArrow;
        isClick = true;
        SelText.text = "비챤";
    }

    void InitClick()
    {
        charPicture0.sprite = NorPicture;
        arrowImg0.sprite = NorArrow;
        charPicture1.sprite = NorPicture;
        arrowImg1.sprite = NorArrow;
        charPicture2.sprite = NorPicture;
        arrowImg2.sprite = NorArrow;
        charPicture3.sprite = NorPicture;
        arrowImg3.sprite = NorArrow;
        charPicture4.sprite = NorPicture;
        arrowImg4.sprite = NorArrow;
        charPicture5.sprite = NorPicture;
        arrowImg5.sprite = NorArrow;
    }
}
