using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossShoot : MonoBehaviour
{
    private Vector3 leftBottomCameraBorder;
    private Vector2 size;

    // Use this for initialization
    void Start()
    {
        //Calcul des angles avec conversion du monde de la caméra au mmonde du pixel pour chaque coin
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(-10, Random.Range(-5,5));

        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;


        if (transform.position.x < leftBottomCameraBorder.x + (size.x / 2))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "ship")
        {
            Destroy(gameObject);
            ExplosionSound.Instance.TouchButtonSound();
            if (GameState.Instance.getLifePlayer() > 5)
            {
                GameState.Instance.RemoveLifePlayer(5);
            }
            else
            {
                Destroy(collider.gameObject);
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }
    }
}
