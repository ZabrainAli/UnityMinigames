﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame

    void Start () 
    {
        pauseMenuUI.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        	if (gameIsPaused)
        	{
        		resume();
        	}
        	else
        	{
        		pause();
        	}
        }
    }

    void resume()
    {
    	pauseMenuUI.SetActive(false);
    	Time.timeScale = 1f;
    	gameIsPaused = false;

    }

    void pause()
    {
    	pauseMenuUI.SetActive(true);
    	Time.timeScale = 0f;
    	gameIsPaused = true;
    }

    public void loadControls()
    {
        Debug.Log("C");
        SceneManager.LoadScene("ControlsMG1");

    }

    public void loadRules()
    {
        Debug.Log("R");
        SceneManager.LoadScene("RulesMG1");
    }
}
