using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VieBoss : MonoBehaviour
{
    private int life = 51;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "shootOrange(Clone)")
        {
            Destroy(collider.gameObject);

            if (life > 1)
            {
                life -= 1;
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
