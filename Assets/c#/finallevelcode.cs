using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finallevelcode : MonoBehaviour
{
    public GameObject ucak, partic;
    private ParticleSystem yardim;
    private Animation anim;



    void Start()
    {
        yardim = partic.gameObject.GetComponent<ParticleSystem>();
        anim = ucak.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay(Collision cube)
    {
        if (cube.gameObject.tag == "cube")
        {
            
            yardim.Play();

            anim.Play("ucakanim");

        }

    }

}
