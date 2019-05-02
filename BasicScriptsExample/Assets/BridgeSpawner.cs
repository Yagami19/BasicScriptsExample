using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSpawner : MonoBehaviour
{


    public GameObject bridge1;
    public GameObject bridge2;

    void Start()
    {
        bridge1.SetActive(false);
        bridge2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        bridge2.SetActive(true);
        bridge1.SetActive(false);
    }


}