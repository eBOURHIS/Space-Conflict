using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Vector2 size;
    private Vector3 tmppos;
    private float desactivate = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        //Debug.Log(Time.time);
        if ((Input.GetKeyDown("space") || Input.touchCount > 0) && Time.time < desactivate)
        {
            //On get la position du tir en fonction de celle du vaisseau
            tmppos = new Vector3(transform.position.x + (size.x), transform.position.y, transform.position.z);

            //On instantie le tir
            GameObject gY = Instantiate(Resources.Load("power_shoot"), tmppos, Quaternion.identity) as GameObject;
            PlayerShotSound.Instance.TouchButtonSound();
        } else if (Time.time > desactivate) 
        {
            desactivate += Time.time;
            enabled = false;
            gameObject.GetComponent<shootAgain>().enabled = true;
        }

    }
}
