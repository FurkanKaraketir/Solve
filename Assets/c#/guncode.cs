using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncode : MonoBehaviour
{
    // Start is called before the first frame update
    public bool tutuldu = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        tutuldu = true;
        firstscenegame.gun = true;

    }
}
