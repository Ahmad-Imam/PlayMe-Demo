using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public scenemanager Scenemanager;
    public static int timer = 10;
    

    public Text timee;
    // Start is called before the first frame update
    void Start()
    {
        timee.text = "Time is " + timer;
        Invoke("count", 1f);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void count()
    {

        if (timer > 0)
        {
            timer--;
            timee.text = "Time is " + timer;
            Invoke("count", 1f);
        }
        else
        {
            Scenemanager.goscene(2);
        }

    }



}
