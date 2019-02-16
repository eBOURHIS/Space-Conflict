using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

    public static GameState Instance;
    private int scorePlayer = 0;
    private int lifePlayer = 5;
    public GameObject[] respawns;

    // Use this for initialization
    void Start () {

		if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance.gameObject);
        }
        else if (this != Instance)
        {
            Debug.Log("Détruit");
            Destroy(this.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {

        respawns = GameObject.FindGameObjectsWithTag("plus");
        GameObject.FindWithTag("scoreLabel").GetComponent<Text>().text = "Score " + scorePlayer;
        //GameObject.FindWithTag("plus").GetComponent<Text>().text = "+1";
        //GameObject.FindWithTag("plus").AddComponent<fadeOut>();

    }

    public void addScorePlayer(int toAdd)
    {
        scorePlayer += toAdd;
    }

    public void ReduceScorePlayer(int toReduce)
    {
        scorePlayer -= toReduce;
    }

    public int getScorePlayer()
    {
        return scorePlayer;
    }

    public void RemoveLifePlayer(int toRemove)
    {
        lifePlayer -= toRemove;
    }

    public int getLifePlayer()
    {
        return lifePlayer;
    }
}
