using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clawscript : MonoBehaviour
{
    public bool openClaws;
    Rigidbody2D Rclaw, Lclaw;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rclaw = GameObject.Find("Right claw").GetComponent<Rigidbody2D>(); 
        Lclaw = GameObject.Find("Left claw").GetComponent<Rigidbody2D>(); 
        openClaws = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            gameObject.transform.Translate(-0.06f,0,0); //Go left
        }

        if (Input.GetKey(KeyCode.D)){
            gameObject.transform.Translate(0.06f,0,0); //Go right
        }

        if (Input.GetKey(KeyCode.W)){
            gameObject.transform.Translate(0,0.06f,0); //Go up
        }

        if (Input.GetKey(KeyCode.S)){
            gameObject.transform.Translate(0,-0.06f,0); //Go down
        }

        if (Input.GetKey(KeyCode.G)){
            openClaws = !openClaws;
        }

        if (Input.GetKey(KeyCode.R)){
        }

        // Convert 0-360° into -180° to 180°
        //if (currentRotation > 180f)
        //    currentRotation -= 360f;

        // Clamp the rotation
        //currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);

        //transform.rotation = Quaternion.Euler(0, 0, currentRotation);

        if (openClaws){
            if (Lclaw.transform.eulerAngles.z < 340){
                Lclaw.transform.Rotate(0, 0, 1f);
            }
            if (Rclaw.transform.eulerAngles.z >  10){
                Rclaw.transform.Rotate(0, 0, -1f);
            }
        }
        
        if (!openClaws){
            if (Lclaw.transform.eulerAngles.z > 300){
                Lclaw.transform.Rotate(0, 0, -1f);
            }
            if (Rclaw.transform.eulerAngles.z < 60){
                Rclaw.transform.Rotate(0, 0, 1f);
            }
        }
    }
}
