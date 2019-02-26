using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootOrange : MonoBehaviour {

    private Vector3 rightBottomCameraBorder;
    private Vector2 size;

    // Use this for initialization
    void Start () {

        //Calcul des angles avec conversion du monde de la caméra au monde du pixel pour chaque coin
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(13, 0);

        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        if (transform.position.x > rightBottomCameraBorder.x + (size.x / 2))
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name != "powerup(Clone)" && collider.name != "boss" && collider.name != "boss_shoot(Clone)")
        {
            //collider destroy
            Destroy(collider.gameObject);
            GameState.Instance.addScorePlayer(1);
            // Shoot destroy 
            Destroy(gameObject);
            ExplosionSound.Instance.TouchButtonSound();
        }
       
    }
}