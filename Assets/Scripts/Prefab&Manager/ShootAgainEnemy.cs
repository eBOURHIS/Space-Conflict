using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAgainEnemy : MonoBehaviour
{
    private Vector2 size;
    private Vector3 tmppos;
    public GameObject[] respawns;
    private float nextShootTime = 0.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        respawns = GameObject.FindGameObjectsWithTag("enemy_spaceship");

        tmppos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //On get la position du tir en fonction de celle du vaisseau

        if (Time.time > nextShootTime)
        {
            nextShootTime += 1;
            GameObject gY = Instantiate(Resources.Load("enemy_shoot"), tmppos, Quaternion.identity) as GameObject;
            //On instantie le tir
            PlayerShotSound.Instance.TouchButtonSound();
        }
    }
}
