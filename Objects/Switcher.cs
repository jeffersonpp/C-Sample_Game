using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Switcher : MonoBehaviour
{
    public bool on = true;
    GameObject lamp;
    Light lamp1;
    public TextMeshProUGUI TMPGUI;
    public History hist;

     void Awake()
     {
        lamp = GameObject.Find("Directional Light 1");
        lamp1 = lamp.GetComponent<Light>();
     }

     void OnMouseDown()
     {
         if(hist.first_step)
         {
            if(on)
            {
                on = false;
                lamp1.enabled = false;
            }
            else
            {
                on = true;
                lamp1.enabled = true;
            }
         }
     }

    void OnMouseOver()
    {
        if(!hist.first_step)
        {
            TMPGUI.text = " Not Working";            
        }
        else if(on)
        {
            TMPGUI.text = " Click to turn OFF";
        }
        else
        {
            TMPGUI.text = " Click to turn On";
        }    
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}

