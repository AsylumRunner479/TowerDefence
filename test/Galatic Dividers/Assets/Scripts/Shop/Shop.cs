﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Shop : MonoBehaviour
{
    public Vector2 scr;
    public static float money;
    // Start is called before the first frame update
    void Start()
    {
        money = 100;
        GUI.Button(new Rect(scr.x * 14.25f, scr.y *  0.5f), scr.x * 2, scr.y * 0.5f), "Money: " + money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}