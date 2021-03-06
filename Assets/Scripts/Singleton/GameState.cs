﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    public static GameState Instance;
    private int scorePlayer = 0;
    private int BestScorePlayer = 0;
    private int lifePlayer = 10;
    public GameObject[] respawns;

    public SimpleHealthBar HealthBar;
    private Scene CurrentScene;

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

        GameObject.FindWithTag("scoreLabel").GetComponent<Text>().text = "Score " + scorePlayer + "/100";
       
        HealthBar = FindObjectOfType<SimpleHealthBar>();

        //Reset du score et de la vie à chaque début de partie.
        CurrentScene = SceneManager.GetActiveScene();
        if (CurrentScene.name == "Menu")
        {
            if (scorePlayer > BestScorePlayer)
            {
                BestScorePlayer = scorePlayer;
                GameObject.FindWithTag("BestScoreLabel").GetComponent<Text>().text = "Best " + BestScorePlayer;
            } else
            {
                GameObject.FindWithTag("BestScoreLabel").GetComponent<Text>().text = "Best " + BestScorePlayer;
            }
            lifePlayer = 10;
            scorePlayer = 0;
        }
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

    public void RemoveLifePlayer(int damage)
    {
        lifePlayer -= damage;
        HealthBar.UpdateBar(lifePlayer, 10);
    }

    public void UpdateHealthBar()
    {
        HealthBar.UpdateBar(lifePlayer, 10);
    }

    public int getLifePlayer()
    {
        return lifePlayer;
    }

    public void AddLifePlayer(int toAdd)
    {
        lifePlayer += toAdd;
        HealthBar.UpdateBar(lifePlayer, 10);
    }
}
