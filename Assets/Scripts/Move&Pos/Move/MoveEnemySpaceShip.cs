using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemySpaceShip : MonoBehaviour
{
    private float nextMove = 0.0f;
    private Vector2 size;
    private Vector3 leftBottomCameraBorder;
    private Vector3 rightBottomCameraBorder;
    private Vector3 rightTopCameraBorder;
    private Vector3 leftTopCameraBorder;

    // Use this for initialization
    void Start()
    {
        //Calcul des angles avec conversion du monde de la caméra au mmonde du pixel pour chaque coin
        //On empêche les vaisseaux de sortir de l'écran car ils ont un déplacement en y aléatoire.
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

    }

    // Update is called once per frame
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

        if (Time.time > nextMove)
        {
            nextMove += 2;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-4, Random.Range(-4, 4));

        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "ship")
        {
            if (GameObject.FindGameObjectWithTag("life5"))
                GameObject.FindGameObjectWithTag("life5").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life4"))
                GameObject.FindGameObjectWithTag("life4").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life3"))
                GameObject.FindGameObjectWithTag("life3").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life2"))
                GameObject.FindGameObjectWithTag("life2").AddComponent<fadeOut>();
            else if (GameObject.FindGameObjectWithTag("life1"))
                GameObject.FindGameObjectWithTag("life1").AddComponent<fadeOut>();

        }

    }
}
