using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posAsteroid : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;
    public float turnSpeed = 6f;


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
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        transform.Rotate(Time.deltaTime, 0, turnSpeed);

        if (transform.position.x < leftBottomCameraBorder.x + (size.x / 2))
            DestroyGameObject();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "ship")
        {
            DestroyGameObject();
            ExplosionSound.Instance.TouchButtonSound();
        }
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }


}

