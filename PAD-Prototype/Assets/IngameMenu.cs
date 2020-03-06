﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameMenu : MonoBehaviour
{

    public static bool gameIsPaused = false, gameIsOver = false;
    public GameObject IngameMenuUI;
    public GameObject GameOverMenuUI;

    public void Start()
    {
        IngameMenuUI.SetActive(false);
        GameOverMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        /*
        if (playerhealth == 0)
        {
            gameIsOver = true;
                if(gameIsOver)
                {
                    GameOver();
                }
        }
        */
    }
    public void Resume()
    {
        IngameMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        IngameMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    void GameOver()
    {
        GameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsOver = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("PlayingScene");
    }
}
