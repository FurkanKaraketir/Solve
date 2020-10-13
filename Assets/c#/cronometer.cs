using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cronometer : MonoBehaviour
{
    // Start is called before the first frame update

    float timer;
    float seconds;
    float minutes;
    float hours;

    bool start;

    public static Text stopWatchText;

    void Start()
    {
        start = true;
        timer = 0;
        stopWatchText = gameObject.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        StopWatchCalcul();
    }

    void StopWatchCalcul()
    {
        if (start)
        {
            timer += Time.deltaTime;
           

            seconds = (int)(timer % 60);
            minutes = (int)((timer / 60) % 60);
            hours = (int)(timer / 3600);

            stopWatchText.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }

    
}
