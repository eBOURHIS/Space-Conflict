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
        InvokeRepeating("Shoot", 0, 1.5f);  //0s délai, répétition toutes les 1.5s
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        respawns = GameObject.FindGameObjectsWithTag("enemy_spaceship"); 
    }

    /// <summary>
    /// Récupère la position des vaissaux ennemis à l'écran et les fait tirer toutes les x secondes définies par l'InvokeRepeating.
    /// </summary>
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