﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
     
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-enemySpeed/10, 0, 0);
       //    scoreboard.text = score.ToString();
        //Debug.Log(score);
    }


}
