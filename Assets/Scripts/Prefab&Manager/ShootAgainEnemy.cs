using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAgainEnemy : MonoBehaviour
{
    private Vector2 size;
    private Vector3 tmppos;
    private GameObject[] respawns;
    private Vector3 enemySpaceShipPos;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Shoot", 0, 1);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        respawns = GameObject.FindGameObjectsWithTag("enemy_spaceship"); 
    }

    void Shoot()
    {
        if (respawns.Length > 0)
        {
            foreach (var ship in respawns)
            {
                // Stockage de la position de chaque vaisseau ennemi à l'écran.
                enemySpaceShipPos = ship.transform.position;
                tmppos = new Vector3(enemySpaceShipPos.x, enemySpaceShipPos.y, enemySpaceShipPos.z);
                //On instantie le tir
                PlayerShotSound.Instance.TouchButtonSound();
                GameObject gY = Instantiate(Resources.Load("enemy_shoot"), tmppos, Quaternion.identity) as GameObject;
            }
        }
    }
}