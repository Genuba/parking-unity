using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Colision : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "paredwin")
        {

            SceneManager.LoadScene("win");
        }
        if (collision.gameObject.name == "paredlose1")
        {
            Application.LoadLevel("lose");
        }
        if (collision.gameObject.name == "paredlose2")
        {
            Application.LoadLevel("lose");
        }
        if (collision.gameObject.name == "paredlose3")
        {
            Application.LoadLevel("lose");
        }

    }
}

