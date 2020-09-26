using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MScreen : MonoBehaviour
{

    public TextMeshProUGUI TMPGUI;
    public History history;

     void OnMouseDown()
     {
        if(history.controller)
        {
            
            Application.ExternalEval("javascript:window.open(\"http://www.jeffersondesousa.com/react\")");
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
            TMPGUI.text = "The Piece at the right place has no borders";            
        }
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}

