using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameState.Instance.getScorePlayer() >= 50)
        {
            SceneManager.LoadScene("Boss", LoadSceneMode.Single);
            Destroy(this);
        }

    }
}
