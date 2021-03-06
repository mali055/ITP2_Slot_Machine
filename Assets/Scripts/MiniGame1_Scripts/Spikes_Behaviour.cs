﻿using UnityEngine;
using System.Collections;

//Behaviour of the spikes objects in minigame 1 and 2
public class Spikes_Behaviour : MonoBehaviour {

    private GameController_2 gameController;
    
    public int SubValue;
    public AudioSource Fruit_Smash;

    // Use this for initialization
    void Start () {

        GameObject GameControllerObject = GameObject.FindWithTag("GameController");
        if (GameControllerObject != null) { gameController = GameControllerObject.GetComponent<GameController_2>(); }
        if (gameController == null){ Debug.Log("Cannot find 'GameController 2' script"); }


    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //Detects collisions
    void OnCollisionEnter2D(Collision2D col)
    {
        //In minigame 1 simply destroy the fruits
        if (col.gameObject.tag == "Cherry" ||
           col.gameObject.tag == "Lemon"   ||
           col.gameObject.tag == "Orange"  ||
           col.gameObject.tag == "Banana")
        {

            Destroy(col.gameObject);

        }

        //In minigame 2 also subtracts points
        if (col.gameObject.tag == "Cherry_2" ||
            col.gameObject.tag == "Lemon_2"  ||
            col.gameObject.tag == "Orange_2" ||
            col.gameObject.tag == "Banana_2")
        {

            Destroy(col.gameObject);
            gameController.SubtractScore(SubValue);
            Fruit_Smash.Play();

        }

   
    }
}
