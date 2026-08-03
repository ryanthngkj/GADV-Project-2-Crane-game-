using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clawscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            gameObject.transform.Translate(-0.03f,0,0); //Go left
        }

        if (Input.GetKey(KeyCode.D)){
            gameObject.transform.Translate(0.03f,0,0); //Go right
        }

        if (Input.GetKey(KeyCode.W)){
            gameObject.transform.Translate(0,0.03f,0); //Go up
        }

        if (Input.GetKey(KeyCode.S)){
            gameObject.transform.Translate(0,-0.03f,0); //Go down
        }

        //if (Input.GetKey(KeyCode.G)){
        
        //}
    }
}
