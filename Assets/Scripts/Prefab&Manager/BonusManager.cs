using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    private Vector2 size;
    private Vector3 tmppos;
    private Vector3 rightBottomCameraBorder;
    private Vector3 rightTopCameraBorder;

    // Use this for initialization
    void Start()
    {
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        InvokeRepeating("SpawnBonus", 10f, Random.Range(15f, 30f));  //0.1s délai, répétition toutes les 15 à 30s
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnBonus()
    {
        tmppos = new Vector3(rightBottomCameraBorder.x + (size.x / 2),
                             Random.Range(rightBottomCameraBorder.y + (size.y / 2),
                             (rightTopCameraBorder.y - (size.y / 2))),
                              transform.position.z);

        if (Random.Range(1,2) == 1)
        {
            GameObject gY = Instantiate(Resources.Load("healthBonus"), tmppos, Quaternion.identity) as GameObject;
        } else if (Random.Range(1, 2) == 2)
        {
            GameObject gY = Instantiate(Resources.Load("healthBonus"), tmppos, Quaternion.identity) as GameObject;
        }


    }
}