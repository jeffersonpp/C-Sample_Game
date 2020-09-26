using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Notes : MonoBehaviour
{
    public TextMeshProUGUI TMPGUI;
    public bool activated = false;
    public bool can_activate = false;
    public bool done = false;

    void OnMouseOver()
    {
        can_activate = true;
        if(done)
        {
            TMPGUI.text = "...";
        }
        else if(activated)
        {
            TMPGUI.text = "You are getting the idea \n but please do it at the keyboard";
        }
        else
        {
           TMPGUI.text = "Important! \n Press the letter J";        
        }

    }

    void OnMouseExit()
    {
        can_activate = false;
        if(activated)
        {
            done = true;
        }
        TMPGUI.text = " ";
    }

    public void AllowIt()
    {
        activated = true;
    }

}

