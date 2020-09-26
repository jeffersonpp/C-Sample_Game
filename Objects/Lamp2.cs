using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lamp2 : MonoBehaviour
{
    public bool on = true;
    public Renderer m_Renderer;
    public Material light_on, light_off;
    public static GameObject lamp;
    public TextMeshProUGUI TMPGUI;
    public History history;

     void Awake()
     {
        m_Renderer = GetComponent<Renderer> ();
        m_Renderer.material =  light_on;
        lamp = this.gameObject;
     }

     void OnMouseDown()
     {
        if(history.first_step)
        {
            if(on)
            {
                on = false;
                m_Renderer.material =  light_off;
                Light lights = lamp.GetComponentsInChildren<Light>(true)[0];
                lights.enabled = false;
            }
            else
            {
                on = true;
                m_Renderer.material =  light_on;
                Light lights = lamp.GetComponentsInChildren<Light>(true)[0];
                lights.enabled = true;
            }
        }
     }

    void OnMouseOver()
    {
        if(!history.first_step)
        {
            TMPGUI.text = " Not Working";            
        }

        else if(on)
        {
            TMPGUI.text = " Click to turn OFF";
        }
        else
        {
            TMPGUI.text = " Click to turn On";
        }    
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}

