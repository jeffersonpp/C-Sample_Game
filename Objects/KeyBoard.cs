using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoard : MonoBehaviour
{
    public TextMeshProUGUI TMPGUI;
    public bool activated = false;
    public bool can_activate = false;
    public bool done = false;
    public History history;
    public AudioClip k_song1;
    int n_audio = 0;
    public float m_timer = 0;
    public float end_timer = 0;
    public Renderer m_Screen;
    public Material screen1, screen2, screen3;
    public Renderer board;
    
    public bool change_song = false;



    void OnMouseOver()
    {
        can_activate = true;
        if(history.controller)
        {
            history.minigame = true;

        }
        else if(done)
        {
            TMPGUI.text = "...";

        }
        else if(activated)
        {

            TMPGUI.text = "GOOD \n Lights working properly now";
            history.first_step=true;
            m_Screen.material = screen1;

        }
        else
        {
           TMPGUI.text = "What a shiny keyboard!";        
        }
    }
    void OnMouseDown()
    {
        if(history.controller)
        {
            m_Screen.material = screen2;
        }
        if(history.minigame)
        {
            board.material = screen3;
           Application.ExternalEval("javascript:window.open(\"http://www.jeffersondesousa.com/react\")");

        }
    }

    void Update()
    {
        if(history.minigame)
        {
           TMPGUI.text = "Look at the board again!";        
 
        }
        if(change_song)
        {
            if(m_timer==0)
            {
            history.audio.clip = k_song1;
            end_timer = history.audio.clip.length;
            history.audio.Play();
            }

            if(m_timer > end_timer)
            {
                change_song = false;
                history.audio.Pause();
                history.audio.clip = history.c_Song;
                history.audio.loop = true;
                history.audio.Play();
            }
            else
            {
                m_timer+=Time.deltaTime;
            }
        }
        else
        {
            m_timer = 0;
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
    public void ChangeSong()
    {
        change_song=true;
    }
}