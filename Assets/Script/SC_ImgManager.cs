using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_ImgManager : MonoBehaviour
{
    private Image img;

    public GameObject[] MemberCG;
    private GameObject ImgCopy;


    private int index;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ImgSizeUp()
    {

        if (gameObject.transform.parent.name != "CGContent")
        {
            Debug.Log("2");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("1");
            ImgCopy = Instantiate(gameObject, gameObject.transform.parent.parent.parent.parent.parent);
            ImgCopy.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            ImgCopy.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            ImgCopy.GetComponent<RectTransform>().sizeDelta = new Vector2(ImgCopy.transform.parent.GetComponent<RectTransform>().rect.width, ImgCopy.transform.parent.GetComponent<RectTransform>().rect.height);
        }
    }
}
