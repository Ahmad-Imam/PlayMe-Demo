﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goscene(int sceneno)
    {
        if (sceneno == 3)
        {
            //Debug.Log("adasdad"+sceneno);
            //repover.SetActive(false);
            Countdown.timer = 7;
            ClicknScore.score = 0;
        }
        SceneManager.LoadScene(sceneno);
    }

    public void endapp()
    {
        Application.Quit();
    }

}