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

    
    public static int finalScore;

    public UIManager UIManager
    {
        get { return uiManager; }
    }

    
    public static GameManager Instance
    {
        get {  return gameManager;  }
    }


    public int currentScore { get; private set; } = 0; 
    

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

        MINIGameData.GameData.LastScore = currentScore;
        finalScore = currentScore;

        Debug.Log("Game Over. Final Score: " + currentScore);


        Player player = FindObjectOfType<Player>();
        if (player != null) { player.StopPlayer(); }

        PlayerPrefs.SetInt("LastScore", currentScore);
        SceneManager.LoadScene("MainScene");



    }

    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        if (uiManager != null)
        {
            uiManager.UpdateScore(currentScore);
        }
        Debug.Log("Score: " + currentScore);
    }


   

}
