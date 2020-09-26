using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onMouseDown : MonoBehaviour
{

    public TextMeshProUGUI TMPGUI;
    // Update is called once per frame
     void OnMouseDown()
     {
         print ("Mouse Down: " + name);    
     }

    void OnMouseOver()
    {
        TMPGUI.text = name;
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}
