using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Plant : MonoBehaviour
{
    public TextMeshProUGUI TMPGUI;


    void OnMouseOver()
    {
        TMPGUI.text = "A Nice Plant!";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }

}

