using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Monitor : MonoBehaviour
{
    public int on = 0;
    public Renderer m_Renderer;
    public Material monitor1, monitor2, monitor3, monitor4, monitor5, monitor6, monitor7;
    public static Material[] mats1,mats2,mats3,mats4,mats5,mats6,mats7; 
    public TextMeshProUGUI TMPGUI;

     void Awake()
     {
        m_Renderer = GetComponent<Renderer> ();
        mats1 = new Material[]{monitor1,monitor1,monitor1};
        mats2 = new Material[]{monitor2,monitor2,monitor2};
        mats3 = new Material[]{monitor3,monitor3,monitor3};
        mats4 = new Material[]{monitor4,monitor4,monitor4};
        mats5 = new Material[]{monitor5,monitor5,monitor5};
        mats6 = new Material[]{monitor6,monitor6,monitor6};
        mats7 = new Material[]{monitor7,monitor7,monitor7};
        TMPGUI.text = " ";
            m_Renderer.materials =  mats1;
     }

     void OnMouseDown()
     {
         if(on==0)
        {

            m_Renderer.materials =  mats2;
        }
         else if(on==1)
         {
            m_Renderer.materials =  mats3;
         }
         else if(on==2)
         {
            m_Renderer.materials =  mats4;
         }
         else if(on==3)
         {
            m_Renderer.materials =  mats5;
         }
         else if(on==4)
         {
            m_Renderer.materials =  mats6;
         }
         else if(on==5)
         {
            m_Renderer.materials =  mats7;
         }
         else
         {
            on = -1;
            m_Renderer.materials =  mats1;
         }
        on++;
     }

    void OnMouseOver()
    {
        TMPGUI.text = " Click to Change Page";
    }

    void OnMouseExit()
    {
        TMPGUI.text = " ";
    }
}