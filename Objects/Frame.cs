using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Frame : MonoBehaviour
{
    public TextMeshProUGUI TMPGUI;


    void OnMouseOver()
    {
        TMPGUI.text = "Interesting!";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }

}

