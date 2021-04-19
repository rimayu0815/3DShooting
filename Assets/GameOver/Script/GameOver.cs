﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        gameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneChange();
        }
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("Title");

        gameOver = false;
    }
}
