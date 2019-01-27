using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootOrange : MonoBehaviour {

    private Vector2 movement;
    public Vector2 speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        movement = new Vector2(
            speed.x * 1,
            speed.y * 0);

        GetComponent<Rigidbody2D>().velocity = movement;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Add the fade script to the gameObject containing this script
        collider.gameObject.AddComponent<Destroy>();
        GameState.Instance.addScorePlayer(1);
        // Shoot destroy 
        Destroy(gameObject);
    }

}