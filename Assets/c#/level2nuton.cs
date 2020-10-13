using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2nuton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject level2yer;
    public Material[] mat;


    void Start()
    {
        level2yer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision cube)
    {
        if (cube.gameObject.tag == "cube")
        {
            
            level2yer.SetActive(true);
            cube.gameObject.GetComponent<Renderer>().material = mat[2];

        }

    }
    void OnCollisionExit(Collision cube1)
    {
        if (cube1.gameObject.tag == "cube")
        {
            
            level2yer.SetActive(false);
            cube1.gameObject.GetComponent<Renderer>().material = mat[1];

        }

    }
}
