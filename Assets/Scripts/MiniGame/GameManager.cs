using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;
    UIManager uiManager;

    public int currentScore = 0;

    public UIManager UIManager
    {
        get { return uiManager; }
    }

    
    public static GameManager Instance
    {
        get {  return gameManager;  }
    }


    private int currentSeore = 0;

    private void Awake()
    {
        gameManager = this; 
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.SetRestart();

        Player player = FindObjectOfType<Player>();
        if (player != null) { player.StopPlayer(); }

        PlayerPrefs.SetInt("LastScore", currentScore);
        SceneManager.LoadScene("MainScene");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentSeore += score;
        uiManager.UpdateScore(currentSeore);
        Debug.Log("Score: " + currentSeore);
    }

}
