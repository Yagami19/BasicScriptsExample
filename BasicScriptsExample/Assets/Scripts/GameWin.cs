using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour {
  

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "player")
        {

            GameState.win = true;


        }
    }
}
