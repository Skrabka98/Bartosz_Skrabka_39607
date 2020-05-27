using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private float predkosc=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, predkosc, 0);
    }
    void OnTriggerEnter(Collider collision)
    {

        if(collision.gameObject.tag == "Player")
        {

            KeepScore.Score += 1;
            Destroy(transform.gameObject);
        }
    }
}
