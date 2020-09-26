using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpecialMug : MonoBehaviour
{

    public TextMeshProUGUI TMPGUI;

     void OnMouseDown()
     {
        TMPGUI.text = "Strange...";
        Application.ExternalEval("window.open(\"http://www.jeffersondesousa.com/entangle\")");
     }

     
    void OnMouseOver()
    {
        TMPGUI.text = "There's something different in that Mug!";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}

