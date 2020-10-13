using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class firstscenegame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject contorlpanel, image, ısık, escpanel, gunFall, gunHand;

    public static bool gun = false;


    int level;





    void Start()
    {
        gunFall.SetActive(true);
        gunHand.SetActive(false);
        ısık.SetActive(false);

        escpanel.SetActive(false);
    }

    // Update is called once per frame





    void Update()
    {
        if (gun == true)
        {
            gunFall.SetActive(false);
            gunHand.SetActive(true);
        }
        if (Input.GetMouseButton(0))
        {

            ısık.SetActive(true);

        }
        else
        {
            ısık.SetActive(false);

        }

        if (Input.GetKey(KeyCode.R) || transform.position.y < -25)
        {
            Application.LoadLevel(Application.loadedLevel);
        }




        if (Input.GetKeyDown(KeyCode.Escape))
        {
            image.SetActive(false);
            escpanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void controlcık()
    {
        escpanel.SetActive(false);
        contorlpanel.SetActive(false);
        image.SetActive(true);
        Time.timeScale = 1;
    }

    public void control()
    {
        escpanel.SetActive(false);
        contorlpanel.SetActive(true);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void resume()
    {
        escpanel.SetActive(false);
        contorlpanel.SetActive(false);

        image.SetActive(true);
        Time.timeScale = 1;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ucak")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }


}
