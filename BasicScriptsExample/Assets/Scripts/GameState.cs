using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

    public static int labCounter;
    public static int ballCounterR;
    public static int ballCounterG;
    public static bool lose;
    public static bool win;


    public GameObject dest;
    public GameObject player;
    public GameObject winner;
    public GameObject loser;
    

    // Use this for initialization
    void Start () {

        labCounter = 0;
        ballCounterR = 0;
        ballCounterG = 0;
        lose = false;
        win = false;
        winner.SetActive(false);
        loser.SetActive(false);
        
    }

    // Update is called once per frame

    public GameObject Instruction;
	void Update () {
		


        if (ballCounterG == 3 && ballCounterR == 3)
        {
            
            player.transform.position = dest.transform.position;
            ballCounterG = 0;


            

        }


        if (lose == true)
        {
            Destroy(player);
            
            loser.SetActive(true);
        }

        if (win == true)
        {
            Destroy(player, 10.0f);
            winner.SetActive(true);
        }

        if (Input.GetButtonDown("Cancel"))
            {
            Application.Quit();
            Debug.Log("Quit");

        }

        if (Input.GetButtonDown("Fire1"))
        {

            
            if (Instruction.active)
            {
                Instruction.SetActive(false);

            }
            else
            {
                Instruction.SetActive(true);
            }

            
        }


    }
}
