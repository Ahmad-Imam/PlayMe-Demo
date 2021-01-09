using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class difficult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void easy(int sceneno)
    {

        targetmovecol1.difficultlvl = 1.5f;
        targetmovecol2.difficultlvl = 1.5f;
        targetmovecol3.difficultlvl = 1.5f;
        Countdown.timer = 15;

        SceneManager.LoadScene(sceneno);
    }


    public void mid(int sceneno)
    {

        targetmovecol1.difficultlvl = 1f;
        targetmovecol2.difficultlvl = 1f;
        targetmovecol3.difficultlvl = 1f;
        Countdown.timer = 10;

        SceneManager.LoadScene(sceneno);
    }

    public void hard(int sceneno)
    {

        targetmovecol1.difficultlvl = .5f;
        targetmovecol2.difficultlvl = .5f;
        targetmovecol3.difficultlvl = .5f;
        Countdown.timer = 8;

        SceneManager.LoadScene(sceneno);
    }


}
