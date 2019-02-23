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
        InvokeRepeating("Shoot", 0f, Random.Range(15f, 30f));  //0.1s délai, répétition toutes les 15 à 30s
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Shoot()
    {
        tmppos = new Vector3(rightBottomCameraBorder.x,
                             Random.Range(rightBottomCameraBorder.y,
                             (rightTopCameraBorder.y)),
                             transform.position.z);
        GameObject gY = Instantiate(Resources.Load("powerup"), tmppos, Quaternion.identity) as GameObject;
    }
}