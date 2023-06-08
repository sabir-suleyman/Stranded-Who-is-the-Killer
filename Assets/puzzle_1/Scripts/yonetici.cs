using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    public string[] sozluk;
    List<GameObject> isaretli_butonlar;
    string kelime = null;
    public bool tiklandi = false;
    public GameObject bitti_panel;
    int puan = 0;
    int bulunan_kelime_sayisi = 0;

    void Start()
    {
        isaretli_butonlar = new List<GameObject>();
    }

    public void isaretli_buton_olustur(GameObject buton)
    {
        isaretli_butonlar.Add(buton);

        kelime = null;

        foreach (GameObject butonlar in isaretli_butonlar)
        {
            kelime = kelime + butonlar.name;
            Debug.Log("Kelime: " + kelime);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiklandi = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            tiklandi = false;
            yazi_olustur();
            Debug.Log("Puan: " + puan);
        }
    }

    void yazi_olustur()
    {
        foreach (string kelimeler in sozluk)
        {
            if (kelimeler == kelime)
            {
                puan += 100;
                bulunan_kelime_sayisi++;

                foreach (GameObject buton in isaretli_butonlar)
                {
                    buton.GetComponent<buton>().yok_ol = true;
                }
            }
        }

        isaretli_butonlar.Clear();
        kelime = null;

        if (bulunan_kelime_sayisi == sozluk.Length)
        {
            bitti_panel.SetActive(true);
        
            SceneManager.LoadScene("SampleScene"); // 3D'ye dönüþ

        }
    }
}
