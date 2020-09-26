using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Printer : MonoBehaviour
{

    public TextMeshProUGUI TMPGUI;
    public History history;

     void OnMouseDown()
     {
        if(history.controller)
        {
            Application.ExternalEval("javascript:window.open(\"http://www.jeffersondesousa.com/print\")");
        }
     }

     
    void OnMouseOver()
    {
        if(!history.controller)
        {
            TMPGUI.text = "Not working yet";
        }
        else
        {
            TMPGUI.text = "Click here to Print the Resume";            
        }
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}

