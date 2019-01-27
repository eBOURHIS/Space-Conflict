using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBkGame : MonoBehaviour
{

    public Vector2 movement;
    public Vector2 size;
    private float positionRestartX;
    private Vector3 leftBottomCameraBorder;

    // Use this for initialization
    void Start()
    {
        movement = new Vector2(-1, 0);
        positionRestartX = -271.191f;
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = movement;
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        if (transform.position.x < leftBottomCameraBorder.x - (size.x / 2))
        {
            transform.position = new Vector3(positionRestartX, transform.position.y, transform.position.z);
        }
    }
}
