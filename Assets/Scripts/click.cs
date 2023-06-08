using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Scene_001"); // Puzzle sahnesinin yüklenmesi
    }
}


