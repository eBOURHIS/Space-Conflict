using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Vector2 size;
    private Vector3 tmppos;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Desactivate", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        if (Input.GetKeyDown("space") || Input.touchCount > 0)
        {
            //On get la position du tir en fonction de celle du vaisseau
            tmppos = new Vector3(transform.position.x + (size.x), transform.position.y, transform.position.z);

            //On instantie le tir
            GameObject gY = Instantiate(Resources.Load("power_shoot"), tmppos, Quaternion.identity) as GameObject;
            PlayerShotSound.Instance.TouchButtonSound();
        }
    }

    void Desactivate()
    {
        Destroy(this);
        GetComponent<shootAgain>().enabled = true;
    }
}
