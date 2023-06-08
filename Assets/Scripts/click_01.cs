using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click_01 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Scene_002"); // Puzzle sahnesinin yüklenmesi
    }
}


