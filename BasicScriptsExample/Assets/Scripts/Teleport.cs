using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject dest;

    void Start()
    {


        



    }




    void OnTriggerStay(Collider other)
    {

        bool isStaying = true;
        

        if (isStaying == true && other.gameObject.tag == "player" && GameState.labCounter >= 4)
        {
            other.gameObject.transform.position = dest.transform.position;
           
        }
    }
}
   
