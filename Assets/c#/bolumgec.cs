using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bolumgec : MonoBehaviour
{


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   

    void OnTriggerEnter(Collider kapı)
    {
        if(kapı.GetComponent<Collider>().tag == "karakter")
        {


            PlayerPrefs.SetInt("bolum",Application.loadedLevel);
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                PlayerPrefs.SetString("time0", cronometer.stopWatchText.text);
            }
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                PlayerPrefs.SetString("time1", cronometer.stopWatchText.text);
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                PlayerPrefs.SetString("time2", cronometer.stopWatchText.text);
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                PlayerPrefs.SetString("time3", cronometer.stopWatchText.text);
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                PlayerPrefs.SetString("time4", cronometer.stopWatchText.text);
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                PlayerPrefs.SetString("time5", cronometer.stopWatchText.text);
            }
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
          

        }



    }
    }


