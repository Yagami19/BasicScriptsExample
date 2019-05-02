using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBall : MonoBehaviour
{



    public Text BallCounterText;


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "goalG")
        {
            Destroy(this.gameObject);
            GameState.ballCounterG++;
            Debug.Log("punkty zielone: " + GameState.ballCounterG);
            BallCounterText.text = (" " + GameState.ballCounterG);
        }

        if (other.gameObject.tag == "goalR")
        {
            Destroy(this.gameObject);
            GameState.ballCounterG--;
            Debug.Log("punkty zielone: " + GameState.ballCounterG);
            BallCounterText.text = (" " + GameState.ballCounterG);
        }
    }
}
