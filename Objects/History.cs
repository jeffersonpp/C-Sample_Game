using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class History : MonoBehaviour
{
    
    public Material credits, first;
    public bool on = false;             //Finish Intro
    public bool first_step = false;
    public bool controller = false;
    public bool bonus = false;
    public bool minigame = false;
    public bool game2 = false;
    public int stage = 0;
    public TextMeshProUGUI TMPGUI;
    GameObject go;
    Renderer m_Renderer;
    public FirstPersonMovement allow_start;
    public Notes note;
    public KeyBoard kboard;
    float start_timer = 0;
    float end_timer = 0;
    
    public AudioSource audio;
    public AudioClip good_to_know, c_Song, c_Intro;

     void Awake()
     {
            go= GameObject.Find("Writing");
            m_Renderer = go.GetComponent<Renderer> ();
            m_Renderer.material =  credits;
            TMPGUI.text = "Please Help Me";
     }

     void Start()
     {
            audio = GetComponent<AudioSource>();
            audio.clip = c_Intro;
            audio.Play();
            end_timer = audio.clip.length;
            start_timer = 0;
     }

public void Update()
{
        if(on)
        {
            // After Presentation
            if(Input.GetKeyDown(KeyCode.J))
            {
                if(note.can_activate)
                {
                    note.AllowIt();
                }    
                if(kboard.can_activate)
                {
                    kboard.AllowIt();
                }    
            }
             else if(Input.GetKeyDown(KeyCode.S))
            {
                if(kboard.can_activate)
                {
                    kboard.ChangeSong();
                }    
            }
             else if(Input.GetKeyDown(KeyCode.L))
            {
                if(kboard.can_activate)
                {
                    bonus = true;
                }    
            }
        }
        else if(start_timer>(end_timer*1.05))
        {
            audio.Pause();
            on = true;
            audio.clip = c_Song;
            audio.loop = true;
            audio.Play();

            m_Renderer.material =  first;
            TMPGUI.text = "Look at the Black Board";
            allow_start.instance.AllowBegin();
        }
        else
        {
            start_timer+=Time.deltaTime;
        }
}

}
