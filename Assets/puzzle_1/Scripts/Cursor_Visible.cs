using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Cursor_Visible : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = true;
        // Releases the cursor
        Cursor.lockState = CursorLockMode.None;
        // Locks the cursor
        //Cursor.lockState = CursorLockMode.Locked;
        // Confines the cursor
        //Cursor.lockState = CursorLockMode.Confined;
    }
}
