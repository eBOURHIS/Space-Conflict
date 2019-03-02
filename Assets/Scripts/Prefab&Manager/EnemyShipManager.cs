using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipManager : MonoBehaviour
{
    public GameObject[] respawns;
    private Vector3 rightBottomCameraBorder;
    private Vector3 rightTopCameraBorder;
    private Vector3 tmpposgX;
    private Vector3 tmpposgY;
    private Vector3 tmpposgZ;
    private Vector2 size;


    // Use this for initialization
    void Start()
    {
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        InvokeRepeating("Spawn", 5f, Random.Range(5, 15));
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        respawns = GameObject.FindGameObjectsWithTag("enemy_spaceship");
    }

    void Spawn()
    {
        tmpposgX = new Vector3(rightBottomCameraBorder.x + (size.x / 2),
                                     Random.Range(rightBottomCameraBorder.y + (size.y / 2),
                                     (rightTopCameraBorder.y - (size.y / 2))),
                                     transform.position.z);

        tmpposgY = new Vector3(rightBottomCameraBorder.x + (size.x / 2),
                                     Random.Range(rightBottomCameraBorder.y + (size.y / 2),
                                     (rightTopCameraBorder.y - (size.y / 2))),
                                     transform.position.z);

        tmpposgZ = new Vector3(rightBottomCameraBorder.x + (size.x / 2),
                                     Random.Range(rightBottomCameraBorder.y + (size.y / 2),
                                     (rightTopCameraBorder.y - (size.y / 2))),
                                     transform.position.z);
        if (Random.Range(1, 10) < 5)
        {
            GameObject gX = Instantiate(Resources.Load("enemy_spaceship"), tmpposgX, Quaternion.identity) as GameObject;
        } else if (Random.Range(1, 10) > 5 && Random.Range(1,10) < 10)
        {
            GameObject gX = Instantiate(Resources.Load("enemy_spaceship"), tmpposgX, Quaternion.identity) as GameObject;
            GameObject gY = Instantiate(Resources.Load("enemy_spaceship"), tmpposgY, Quaternion.identity) as GameObject;
        } else
        {
            GameObject gX = Instantiate(Resources.Load("enemy_spaceship"), tmpposgX, Quaternion.identity) as GameObject;
            GameObject gY = Instantiate(Resources.Load("enemy_spaceship"), tmpposgY, Quaternion.identity) as GameObject;
            GameObject gZ = Instantiate(Resources.Load("enemy_spaceship"), tmpposgZ, Quaternion.identity) as GameObject;
        }
    }
}