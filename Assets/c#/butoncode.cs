using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butoncode : MonoBehaviour
{
    public float cubeSize = 0.1f;
    public float cubesInRow = 5;
    public float explosionRadius = 4;
    public float explosionForce = 50;
    public float explosionUpword = 0.4f;

    float cubesPivotDistance;
    Vector3 cubesPivot;
    // Start is called before the first frame update
    public bool butonbasılı;
    public GameObject kapı;
    public AudioSource ses;
    public AudioSource explosionSfx;
   
    public Material[] mat;
    void Start()
    {
        cubesPivotDistance = cubeSize * cubesInRow / 2;
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
        kapı.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionStay(Collision cubeG)
    {
        if (cubeG.gameObject.tag == "cube")
        {
            butonbasılı = true;
            kapı.SetActive(false);
            cubeG.gameObject.GetComponent<Renderer>().material = mat[2];

        }
        if (cubeG.gameObject.tag == "cubeerror")
        {
            butonbasılı = false;
            kapı.SetActive(true);
            ses.Play();
            cubeG.gameObject.GetComponent<Renderer>().material = mat[0];
            StartCoroutine(ExampleCoroutine(cubeG.gameObject));

        }


    }


    void OnCollisionExit(Collision cube1)
    {
        if (cube1.gameObject.tag == "cube")
        {
            butonbasılı = false;
            kapı.SetActive(true);
        }

    }

    IEnumerator ExampleCoroutine(GameObject cubeG)
    {

        yield return new WaitForSeconds(4);
        cubeG.GetComponent<MeshRenderer>().material = mat[3];
        explosionSfx.Play();
        
        yield return new WaitForSeconds(1.7f);
        
        explode(cubeG.gameObject);
    }

    public void explode(GameObject kup)
    {
        kup.SetActive(false);
        createPiece(kup.gameObject);
        Vector3 explosionPos = kup.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, kup.transform.position, explosionRadius, explosionUpword);
            }
        }
    }


    void createPiece(GameObject kup)
    {
        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        piece.transform.position = kup.transform.position;
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize) - cubesPivot;

        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;
        piece.AddComponent<MeshFilter>();
        piece.AddComponent<MeshRenderer>();

        piece.GetComponent<MeshRenderer>().material = mat[0];
    }


}