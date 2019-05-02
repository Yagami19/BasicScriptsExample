using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBallR : MonoBehaviour
{



    public Text BallCounterText;
    


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "goalR")
        {
            Destroy(this.gameObject);
            GameState.ballCounterR++;
            Debug.Log("punkty czerwone: " + GameState.ballCounterR);
            BallCounterText.text = (" " + GameState.ballCounterR);

        }

        if (other.gameObject.tag == "goalG")
        {
            Destroy(this.gameObject);
            GameState.ballCounterR--;
            Debug.Log("punkty czerwone: " + GameState.ballCounterR);
        }
    }
}
