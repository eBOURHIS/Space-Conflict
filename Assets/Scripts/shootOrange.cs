using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootOrange : MonoBehaviour {

    private Vector2 movement;
    public Vector2 speed;
    private Vector3 leftBottomCameraBorder;
    private Vector3 rightBottomCameraBorder;
    private Vector3 rightTopCameraBorder;
    private Vector3 leftTopCameraBorder;
    private Vector2 size;

    // Use this for initialization
    void Start () {

        //Calcul des angles avec conversion du monde de la caméra au mmonde du pixel pour chaque coin
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {

        movement = new Vector2(
            speed.x * 1,
            speed.y * 0);

        GetComponent<Rigidbody2D>().velocity = movement;

        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;


        if (transform.position.x > rightBottomCameraBorder.x + (size.x / 2))
            DestroyGameObject();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Add the fade script to the gameObject containing this script
        collider.gameObject.AddComponent<Destroy>();
        GameState.Instance.addScorePlayer(1);
        // Shoot destroy 
        Destroy(gameObject);
        ExplosionSound.Instance.TouchButtonSound();
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}