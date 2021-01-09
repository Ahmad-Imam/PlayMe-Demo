using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{
    
    public GameObject winner;
    public Text finalscr;
    public Text hiscore;
    public bool winselect = false;
    public scenemanager sceneobj;
    // Start is called before the first frame update
    void Start()
    {
        
        winner.SetActive(false);
        gmeover();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void gmeover()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sceneobj.goscene(0);
            Debug.Log("sfasdf");
        }

        if (Countdown.timer < 1)
        {
            //sceneobj.goscene(2);
            finalscr.text = "Final Score is " + ClicknScore.fnlscr;
            hiscore.text = "HighScore is " + PlayerPrefs.GetInt("hscore");


        }

        if (PlayerPrefs.GetInt("hscore") < ClicknScore.score)
        {
            Debug.Log("hihasd");
            winselect = true;
            if (winselect == true)
            {
                winner.SetActive(true);
            }
            PlayerPrefs.SetInt("hscore", ClicknScore.score);
        }
        else
        {
            //Debug.Log("oknqwe");
        }

    }


}
