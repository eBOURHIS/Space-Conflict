using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemyShip : MonoBehaviour
{

    public Vector2 speed;
    private Vector2 movement;
    private float spriteMove;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Calcul du mouvement
        movement = new Vector2(
            speed.x * 1,
            speed.y * 0);

        GetComponent<Rigidbody2D>().velocity = movement;
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
