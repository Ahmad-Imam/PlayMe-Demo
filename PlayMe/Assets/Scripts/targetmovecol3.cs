﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetmovecol3 : MonoBehaviour
{
    public static float difficultlvl;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("move1", 2f);

    }

    // Update is called once per frame
    void Update()
    {

    }


    void move1()
    {


        transform.position = new Vector3(Random.Range(-8f, 8f), -1.8f, 0);
        //Debug.Log(transform.position);

        Invoke("move2", difficultlvl);

    }
    void move2()
    {

        transform.position = new Vector3(Random.Range(-8f, 8f), -3.5f, 0);
        //Debug.Log(transform.position);
        Invoke("move1", difficultlvl);

    }





}
