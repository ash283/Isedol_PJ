using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_MenuPrefab : MonoBehaviour
{
    public GameObject LoadBtnPrefab;
    public GameObject CGBtnPrefab;
    public GameObject CharMenu;

    private int pastMemberNum;
    private int NowMemberNum;
    private int Mode;           // 1.로드, 2.CG

    // Start is called before the first frame update
    void Start()
    {
        pastMemberNum = 0;
        if (gameObject.name == "LoadContent" && gameObject.transform.parent.name == "LoadViewport")
        {
            Mode = 1;
            for (int i = 0; i < 10; i++)
            {
                GameObject go = Instantiate(LoadBtnPrefab);
                go.transform.SetParent(gameObject.transform, false);
            }
        }
        else if (gameObject.name == "CGContent" && gameObject.transform.parent.name == "CGViewport")
        {
            Mode = 2;
            for (int i = 0; i < 6; i++)
            {
                GameObject go = Instantiate(CGBtnPrefab);
                go.transform.SetParent(gameObject.transform, false);
            }
            for (int i = 0; i < 6; i++)
            {
                Transform child = gameObject.transform.GetChild(i);
                GameObject childImg = child.GetComponent<SC_ImgManager>().MemberCG[pastMemberNum];  //버튼 누르면 변하는 변수를 가져다 씀.                                
                child.GetComponent<Image>().sprite = childImg.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (Mode)
        {
            case 1:
                break;
            case 2:
                NowMemberNum = CharMenu.GetComponent<SC_BtnChar>().MemberNum;
                if (NowMemberNum != pastMemberNum)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        Transform child = gameObject.transform.GetChild(i);
                        GameObject childImg = child.GetComponent<SC_ImgManager>().MemberCG[NowMemberNum];  //버튼 누르면 변하는 변수를 가져다 씀.                
                        child.GetComponent<Image>().sprite = childImg.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite;
                    }
                    pastMemberNum = NowMemberNum;
                }
                break;

        }

    }
}
