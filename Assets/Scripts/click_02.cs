using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click_02 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Scene_003"); // Puzzle sahnesinin yüklenmesi
    }
}


