using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clawscript : MonoBehaviour
{
    public bool openClaws;
    Rigidbody2D Rclaw, Lclaw;
    void Start()
    {
        Rclaw = GameObject.Find("Right claw").GetComponent<Rigidbody2D>(); //Extracts the rigidbody components of
        Lclaw = GameObject.Find("Left claw").GetComponent<Rigidbody2D>(); //both claws to use later in the code
        openClaws = false; // The claw starts in a closed state since its set to false
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-0.06f,0,0); //Go left
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(0.06f,0,0); //Go right
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0,0.06f,0); //Go up
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0,-0.06f,0); //Go down
        }

        if (Input.GetKey(KeyCode.G))
        {
            openClaws = !openClaws; // " ! " is called a NOT operator, basically flipping the value of openClaws
        }                           //from false to true, so pressing G will open the claws, and pressing it again
                                    //will close them
                                    //(this is also so that the player won't need to hold down G)
                                    //TLDR it swaps True to false and vice versa

        if (openClaws) //For when the claws are open 
        {
            if (Lclaw.transform.eulerAngles.z < 350) //Checks if the angle of the left claw is < 350 degrees
            {
                Lclaw.transform.Rotate(0, 0, 1f); //Automatically rotates the left claw to 350 degrees
            }

            if (Rclaw.transform.eulerAngles.z >  10)  //Checks if the angle of the right claw is > 10 degrees
            {
                Rclaw.transform.Rotate(0, 0, -1f); //Automatically rotates the right claw to 10 degrees
            }
        }
        
        if (!openClaws) //For when the claws are closed (The state the claw starts in)
        {
            if (Lclaw.transform.eulerAngles.z > 300)  //Checks if the angle of the left claw is > 300 degrees
            {
                Lclaw.transform.Rotate(0, 0, -1f); //Automatically rotates the left claw to 300 degrees
            }

            if (Rclaw.transform.eulerAngles.z < 60)  //Checks if the angle of the right claw is < 60 degrees
            {
                Rclaw.transform.Rotate(0, 0, 1f); //Automatically rotates the right claw to 60 degrees
            }
        }
    }
}
