using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VieBoss : MonoBehaviour
{
    private int life = 51;
    private Color cl;

    // Start is called before the first frame update
    void Start()
    {
        cl = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.name == "shootOrange(Clone)" || collider.name == "power_shoot(Clone)")
        {
            Destroy(collider.gameObject);

            if (life > 1)
            {
                life -= 1;
                cl.g -= 0.02f;
                cl.b -= 0.02f;
                GetComponent<SpriteRenderer>().color = cl;
                ExplosionSound.Instance.TouchButtonSound();
            } else if (life == 1)
            {
                Destroy(gameObject);
                ExplosionSound.Instance.TouchButtonSound();
                SceneManager.LoadScene("Victory", LoadSceneMode.Single);
            }
           

           
        }
    }
}
