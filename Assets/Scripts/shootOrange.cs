using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootOrange : MonoBehaviour {

    private Vector3 rightBottomCameraBorder;
    private Vector2 size;
    private GameObject[] plus;

    // Use this for initialization
    void Start () {

        //Calcul des angles avec conversion du monde de la caméra au mmonde du pixel pour chaque coin
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(30, 0);

        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        plus = GameObject.FindGameObjectsWithTag("plus");

        if (transform.position.x > rightBottomCameraBorder.x + (size.x / 2))
            DestroyGameObject();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
            collider.gameObject.AddComponent<Destroy>();
            GameState.Instance.addScorePlayer(1);
            GameObject gY = Instantiate(Resources.Load("plus"), new Vector3(4, 4, 0), Quaternion.identity) as GameObject;
            // Shoot destroy 
            Destroy(gameObject);
            ExplosionSound.Instance.TouchButtonSound();
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}