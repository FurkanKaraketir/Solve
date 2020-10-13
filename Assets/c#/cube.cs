using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    

    float atmagucu = 600;
    Vector3 objepos;
    float mesafe;


    public bool tutulabilir = false;
    public GameObject mavicube;
    public GameObject gecsabit;
    public bool tutuluyor = false;

    void Update()
    {



        if (transform.position.y < -20)
        {
            gameObject.SetActive(false);


        }
        if (firstscenegame.gun == true)
        {

            mesafe = Vector3.Distance(mavicube.transform.position, gecsabit.transform.position);
            if (mesafe > 4)
            {
                tutuluyor = false;
            }


            if (tutuluyor == true)
            {
                mavicube.GetComponent<Rigidbody>().velocity = Vector3.zero;
                mavicube.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                mavicube.transform.SetParent(gecsabit.transform);

                if (Input.GetMouseButtonDown(1))
                {
                    mavicube.GetComponent<Rigidbody>().AddForce(gecsabit.transform.forward * atmagucu);
                    tutuluyor = false;
                }


            }
            else
            {
                objepos = mavicube.transform.position;
                mavicube.transform.SetParent(null);
                mavicube.GetComponent<Rigidbody>().useGravity = true;
                mavicube.transform.position = objepos;
            }
        }


    }

    void OnMouseDown()
    {
        if (firstscenegame.gun == true)
        {
            tutuluyor = true;
            mavicube.GetComponent<Rigidbody>().useGravity = false;
            mavicube.GetComponent<Rigidbody>().detectCollisions = true;
        }
    }

    void OnMouseUp()
    {
        tutuluyor = false;

    }

   

}
