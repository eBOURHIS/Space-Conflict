﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAgainBoss : MonoBehaviour
{
    private Vector2 size;
    private Vector3 tmppos;
    private GameObject[] respawns;
    private Vector3 enemySpaceShipPos;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Shoot", 2f, 1f);  //0.1s délai, répétition toutes les 1.5s
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    /// <summary>
    /// Récupère la position des vaissaux ennemis à l'écran et les fait tirer toutes les x secondes définies par l'InvokeRepeating.
    /// </summary>
    void Shoot()
    {
                // Stockage de la position de chaque vaisseau ennemi à l'écran.
                tmppos = new Vector3(transform.position.x - (size.x / 2), transform.position.y, transform.position.z);
                //On instantie le tir
                BossShootSound.Instance.TouchButtonSound();
                GameObject gY = Instantiate(Resources.Load("boss_shoot"), tmppos, Quaternion.identity) as GameObject;
    }
}