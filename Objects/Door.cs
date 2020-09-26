using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{

    public TextMeshProUGUI TMPGUI;

     void OnMouseDown()
     {
        Application.OpenURL( "http://www.jeffersondesousa.com/curriculum" );
     }

     
    void OnMouseOver()
    {
        TMPGUI.text = "Click here to Go Away";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}

