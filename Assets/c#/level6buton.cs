using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6buton : MonoBehaviour
{
   
    public GameObject level6kapı;

    void Start()
    {
        level6kapı.SetActive(true);
    }

    // Update is called once per frame
    
   
    void OnCollisionStay(Collision cube)
    {
        if (cube.gameObject.tag == "cube")
        {

            level6kapı.SetActive(false);
        }

    }
    void OnCollisionExit(Collision cube1)
    {
        if (cube1.gameObject.tag == "cube")
        {

            level6kapı.SetActive(true);
        }

    }

}
