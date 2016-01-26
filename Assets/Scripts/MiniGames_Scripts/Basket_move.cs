﻿using UnityEngine;
using System.Collections;

public class Basket_move : MonoBehaviour {

    float MoveSpeed = 0.2f; //If you set it to public it will show in the unity GUI

    
    


    // Use this for initialization
    void Start () {

        

	}

	// Update is called once per frame
	void Update () {

        HandleMovement();

        


    }


    void HandleMovement()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(MoveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-MoveSpeed, 0, 0);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Fruit")
        {

            Destroy(col.gameObject);

        }
    }

 
}