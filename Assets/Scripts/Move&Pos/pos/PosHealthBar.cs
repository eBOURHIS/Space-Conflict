using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosHealthBar : MonoBehaviour
{
    private GameObject player;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player)
        {
            pos = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
            transform.position = pos;
        }
        

    }
}
