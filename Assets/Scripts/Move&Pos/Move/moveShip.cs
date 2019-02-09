using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveShip : MonoBehaviour {

    //1 - La vitesse de déplacement
    public Vector2 speed;
    private GameObject[] asteroid;
    private Vector2 movement;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        //Récupération des informations du clavier/manette
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        // Calcul du mouvement
        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        GetComponent<Rigidbody2D>().velocity = movement;
        asteroid = GameObject.FindGameObjectsWithTag("asteroid");

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (asteroid.Length > 0)
        {
            if(GameState.Instance.getLifePlayer() > 1)
            {
                GameState.Instance.RemoveLifePlayer(0);
            } else
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
        }
    }
}

