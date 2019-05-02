using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{

    int mov;
    void Start()
    {
        mov = 10;
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * mov);

    }


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "player")
        {
            SceneManager.LoadScene("Plansze");

        }

        if (other.gameObject.tag == "box")
        {
            mov = mov * -1;

        }
    }



}

