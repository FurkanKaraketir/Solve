using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastlevelcode : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public Text BestScoreText;
    public int skor = 999999999;


    void Start()
    {
        string[] Asamalar = new string[] { PlayerPrefs.GetString("time0"), PlayerPrefs.GetString("time1"), PlayerPrefs.GetString("time2"), PlayerPrefs.GetString("time3"), PlayerPrefs.GetString("time4"), PlayerPrefs.GetString("time5") };
        int[] toplamlar = new int[3];
        for (int i = 0; i < Asamalar.Length; i++)
        {

            string[] strZaman = Asamalar[i].Split(':');

            for (int j = 0; j < strZaman.Length; j++)
            {

                toplamlar[j] += int.Parse(strZaman[j]);

            }
        }

        while (toplamlar[2] > 60)
        {

            toplamlar[2] -= 60;
            toplamlar[1] += 1;

        } while (toplamlar[1] > 60)
        {

            toplamlar[1] -= 60;
            toplamlar[0] += 1;

        }


        text.text = "Birinci Aşama: " + PlayerPrefs.GetString("time0") + "\n" + "İkinci Aşama: " + PlayerPrefs.GetString("time1") + "\n" + "Üçüncü Aşama: " + PlayerPrefs.GetString("time2") + "\n" + "Dördüncü Aşama: " + PlayerPrefs.GetString("time3") + "\n" + "Beşinci Aşama: " + PlayerPrefs.GetString("time4") + "\n" + "Altıncı Aşama: " + PlayerPrefs.GetString("time5") + "\n" + "Toplam Süre: " + toplamlar[0] + " Saat, " + toplamlar[1] + " Dakika, " + toplamlar[2] + " Saniye";
        int yeniskor = toplamlar[0] * 3600 + toplamlar[1] * 60 + toplamlar[2];

        if (PlayerPrefs.GetInt("skor") >= yeniskor)
        {
            PlayerPrefs.SetInt("skor", yeniskor);
   

        }

        int bsSaniye = PlayerPrefs.GetInt("skor");
        int bsSaat = (bsSaniye / 3600);
        int bsDa = (bsSaniye / 60);

        while (bsSaniye > 60)
        {

            bsSaniye -= 60;
            bsDa += 1;

        } while (bsDa > 60)
        {

            bsDa -= 60;
            bsSaat += 1;

        }

        BestScoreText.text = "En Yüksek Skorunuz: " + bsSaat + " Saat, " + bsDa + " Dakika, " + bsSaniye + " Saniye";



    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
