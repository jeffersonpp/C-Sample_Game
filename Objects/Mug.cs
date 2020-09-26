using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mug : MonoBehaviour
{
    public TextMeshProUGUI TMPGUI;


    void OnMouseOver()
    {
        TMPGUI.text = "Don't mess with my Full Stack Coffee!";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }

}

