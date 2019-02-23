using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAgain : MonoBehaviour {

    private Vector2 size;
    private Vector3 tmppos;
    private float nextShootTime = 0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        size.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        size.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;

        if ((Input.GetKeyDown("space") || Input.touchCount > 0) && Time.time > nextShootTime)
        {
            //On get la position du tir en fonction de celle du vaisseau
            tmppos = new Vector3(transform.position.x + (size.x), transform.position.y, transform.position.z);
            //On instantie le tir
            GameObject gY = Instantiate(Resources.Load("shootOrange"), tmppos, Quaternion.identity) as GameObject;
            PlayerShotSound.Instance.TouchButtonSound();
            nextShootTime = Time.time + 0.3f;    // temps entre chaque tir pour éviter de le spammer
        }
    }
}
