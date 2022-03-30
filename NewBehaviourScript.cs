using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = Multi(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            // gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }

    int Multi(int sayi)
    {
        int result;
        result = sayi * 5;
        return result;
    }
}
