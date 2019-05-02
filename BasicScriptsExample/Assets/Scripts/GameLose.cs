using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "player")
        {

            GameState.lose = true;


        }
    }
}
