using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDown : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Awake()
    {
    Screen.lockCursor = true;
    }

    void Update()
    {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.lockState = CursorLockMode.None;       
    }
}
