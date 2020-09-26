using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jay : MonoBehaviour
{
    public TextMeshProUGUI TMPGUI;
    public KeyBoard kboard;


    void OnMouseOver()
    {

        TMPGUI.text = "Letter J";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }

    public void OnMouseDown()
    {
            kboard.AllowIt();
    }

}

