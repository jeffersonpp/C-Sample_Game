using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{

    public TextMeshProUGUI TMPGUI;
    public History history;
    public GameObject controller;

     void OnMouseDown()
     {
        if(history.first_step)
        {
            history.controller = true;
            controller.active = false;
        }
     }

     
    void OnMouseOver()
    {
        if(!history.first_step)
        {
            TMPGUI.text = "Can't Hold Him yet";
        }
        else
        {
            TMPGUI.text = "Use this PS Controller \n to play another game";
        }
    }

    void OnMouseExit()
    {
        if(history.first_step)
        TMPGUI.text = " Click at the Keyboard to see the game";
    }
}

