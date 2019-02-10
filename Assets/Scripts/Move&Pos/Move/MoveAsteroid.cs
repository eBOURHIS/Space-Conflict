using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-5,0);
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
