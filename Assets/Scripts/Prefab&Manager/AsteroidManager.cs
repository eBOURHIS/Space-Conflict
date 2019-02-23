using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    private GameObject[] respawns;
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
        respawns = GameObject.FindGameObjectsWithTag("asteroid");

        if (respawns.Length < 10)
        {
            if (Random.Range(1,500) == 50 || respawns.Length < 6)
            {
                tmppos = new Vector3(rightBottomCameraBorder.x + (size.x / 2),
                                    Random.Range(rightBottomCameraBorder.y + (size.y / 2),
                                    (rightTopCameraBorder.y - (size.y / 2))),
                                    transform.position.z);

                GameObject gY = Instantiate(Resources.Load("asteroid"), tmppos, Quaternion.identity) as GameObject;
            }
        }
    }
}