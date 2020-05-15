using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    GameObject szukany;

    GameObject[] szukane;

    // Start is called before the first frame update
    void Start()
    {
        szukany = GameObject.Find("Sphere");
        //szukany = GameObject.FindGameObjectWithTag("do_usuniecia");

        szukane = GameObject.FindGameObjectsWithTag("do_usuniecia");
        foreach(GameObject s in szukane)
        {
            Destroy(s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
