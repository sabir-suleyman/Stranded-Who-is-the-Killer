using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class turn_back : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene"); // 3D'ye dönüþ
    }
}


