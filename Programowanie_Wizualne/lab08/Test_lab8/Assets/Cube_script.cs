using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cube_script : MonoBehaviour
{
    Vector3 pozycja = new Vector3(10, 0, 0);

    public float predkosc;
    public String os;
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
        //print(transform.position.x);

        //transform.position = pozycja;
        //transform.position = new Vector3(5, 5, 5);

    }

    // Update is called once per frame
    void Update()
    {
        if (os == "x")
        {
            transform.Rotate(predkosc, 0, 0);
        }
        if (os == "y")
        {
            transform.Rotate(0, predkosc, 0);
        }
        if (os == "z")
        {
            transform.Rotate(0, 0, predkosc);
        }
    }
}
