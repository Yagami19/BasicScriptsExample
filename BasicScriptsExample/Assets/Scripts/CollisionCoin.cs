using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCoin : MonoBehaviour {

    

    void Start()
    {
        

    }

    public Text CoinCounterText;


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
            GameState.labCounter++;
            Debug.Log(GameState.labCounter);
            CoinCounterText.text = (" " + GameState.labCounter);
        }
    }
}
