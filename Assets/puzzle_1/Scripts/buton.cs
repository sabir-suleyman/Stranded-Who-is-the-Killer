using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buton : MonoBehaviour
{
    yonetici yonet;
    Image renk;
    RectTransform buyukluk;
    string harf;
    bool harf_verildi = false;
    float kuculme_miktarý = 0.08f;
    public bool yok_ol = false;

    void Start()
    {
        yonet = FindObjectOfType<yonetici>();
        renk = GetComponent<Image>();
        buyukluk = GetComponent<RectTransform>();
        harf = gameObject.name;
    }

    void Update()
    {
        if (yonet.tiklandi == false)
        {
            harf_verildi = false;
            renk.color = Color.white;
        }

        if (yok_ol == true)
        {
            buyukluk.localScale -= new Vector3(kuculme_miktarý, kuculme_miktarý, kuculme_miktarý);

            if (buyukluk.localScale.x <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void yesil_ol()
    {
        if (yonet != null && yonet.tiklandi == true)
        {
            renk.color = Color.green;

            if (harf_verildi == false)
            {
                yonet.isaretli_buton_olustur(gameObject);
                harf_verildi = true;
            }
        }
    }
}