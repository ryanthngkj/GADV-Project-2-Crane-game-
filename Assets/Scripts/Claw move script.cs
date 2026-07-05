using UnityEngine;

public class Clawmovescript : MonoBehaviour
{
    private Rigidbody2D clawBody;
    private Vector2 clawMove;
    public float speed = 40f; // Allows speed to be changed from the side menu
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clawBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {    // Claw go left when press A
            clawMove = Vector2.left; 
        }
        else if (Input.GetKey(KeyCode.D)){  // Claw go right when press D
            clawMove = Vector2.right;
        } 
        else {
                clawMove = Vector2.zero;
        }
    }

    void FixedUpdate(){
        if (clawMove == Vector2.zero) { // If no input, claw stop moving
            return;
        }
        clawBody.AddForce (clawMove * speed); // Makes it so claw accelerates a little
    }
}



