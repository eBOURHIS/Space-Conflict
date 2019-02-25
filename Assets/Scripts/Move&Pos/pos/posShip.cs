using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posShip : MonoBehaviour
{
    // Stockage du mouvement
    private Vector2 movement;
    private Vector3 leftBottomCameraBorder;
    private Vector3 rightBottomCameraBorder;
    private Vector3 rightTopCameraBorder;
    private Vector3 leftTopCameraBorder;
    private Vector2 size;

    // Use this for initialization
    void Start()
    {
        //Calcul des angles avec conversion du monde de la caméra au mmonde du pixel pour chaque coin
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
    }
    void Update()
    {
           size = new Vector2(
           size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x,
           size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y);

        //Bottom of the screen
        if (transform.position.y < leftBottomCameraBorder.y + (size.x / 2))
            transform.position = new Vector3(transform.position.x, leftBottomCameraBorder.y + (size.x / 2), transform.position.z);

        //Top of the screen
        if (transform.position.y > leftTopCameraBorder.y - (size.x / 2))
            transform.position = new Vector3(transform.position.x, leftTopCameraBorder.y - (size.x / 2), transform.position.z);

        //Right of the screen
        if (transform.position.x > rightBottomCameraBorder.x - (size.x / 2))
            transform.position = new Vector3(rightBottomCameraBorder.x - (size.x / 2), transform.position.y, transform.position.z);

        //Left of the screen
        if (transform.position.x < leftBottomCameraBorder.x + (size.x / 2))
            transform.position = new Vector3(leftBottomCameraBorder.x + (size.x / 2), transform.position.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "powerup(Clone)")
        {
            gameObject.GetComponent<shootAgain>().enabled = false;
            gameObject.GetComponent<PowerUp>().enabled = true;
            Destroy(collider.gameObject);
        }

    }
}

