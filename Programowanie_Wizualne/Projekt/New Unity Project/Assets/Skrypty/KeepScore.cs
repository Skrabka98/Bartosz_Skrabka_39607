﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 100), "Zebrane\nPunkty\n\n" +Score);
    }
}
