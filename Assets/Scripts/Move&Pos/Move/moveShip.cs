﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour {

    //1 - La vitesse de déplacement
    private Vector2 speed;
    private Vector2 movement;

    // Use this for initialization
    void Start () {

        speed = new Vector2(15, 15);

    }

    // Update is called once per frame
    void Update () {

        //Récupération des informations du clavier/manette
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        // Calcul du mouvement
        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        GetComponent<Rigidbody2D>().velocity = movement;

    }
}

