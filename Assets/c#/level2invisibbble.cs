using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2invisibbble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider duvar)
    {
        if (gameObject.GetComponent<Collider>().tag == "karakter")
        {

            gameObject.GetComponent<BoxCollider>().isTrigger = false;

        }
        else
        {
            duvar.GetComponent<BoxCollider>().isTrigger = true;
        }



    }

}
