using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBonus : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-5, Random.Range(-1.0f, 1.0f));
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "ship")
        {
            gameObject.GetComponent<PowerUp>().enabled = true;
        }

    }
}
