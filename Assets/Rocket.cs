using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }
    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Boosters Engaged");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right");
        }
    }
}
