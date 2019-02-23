using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipManager : MonoBehaviour
{
    public GameObject[] respawns;
    private Vector3 rightBottomCameraBorder;
    private Vector3 rightTopCameraBorder;
    private Vector3 tmppos;
    private Vector2 size;


    // Use this for initialization
    void Start()
    {
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        respawns = GameObject.FindGameObjectsWithTag("enemy_spaceship");

        if (respawns.Length < 2)
        {
            {
                tmppos = new Vector3(rightBottomCameraBorder.x + (size.x / 2),
                                     Random.Range(rightBottomCameraBorder.y + (size.y / 2),
                                     (rightTopCameraBorder.y - (size.y / 2))),
                                     transform.position.z);
                GameObject gY = Instantiate(Resources.Load("enemy_spaceship"), tmppos, Quaternion.identity) as GameObject;
            }
        }
    }
}