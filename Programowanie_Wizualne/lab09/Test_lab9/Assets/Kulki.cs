using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulki : MonoBehaviour
{

    public GameObject[] kulka;

    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("GenerujKulki", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CancelInvoke();
        }
       else if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerujKulki();
        }
      else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(kulka[0], transform.position - new Vector3(0,1f,0), Quaternion.identity);
        }
       else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(kulka[1], transform.position - new Vector3(0,1f,0), Quaternion.identity);
        }
       else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(kulka[2], transform.position - new Vector3(0, 1f, 0), Quaternion.identity);
        }
       else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Instantiate(kulka[3], transform.position - new Vector3(0, 1f, 0), Quaternion.identity);
        }
       else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Instantiate(kulka[4], transform.position - new Vector3(0, 1f, 0), Quaternion.identity);
        }

    }

    void GenerujKulki()
    {
        int los = Random.Range(0, kulka.Length);
        Instantiate(kulka[los], transform.position - new Vector3(0, 1f, 0), Quaternion.identity);
    }

    void Losowanie()
    {
        GenerujKulki();
    }
    }
