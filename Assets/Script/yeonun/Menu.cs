using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject menuset;
    public GameObject save;


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuset.activeSelf)
            {
                menuset.SetActive(false);
            }
            else
                menuset.SetActive(true);
               
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (save.activeSelf)
            {
                save.SetActive(false);
            }

            else
                save.SetActive(true);   


        }



    }
       



}
