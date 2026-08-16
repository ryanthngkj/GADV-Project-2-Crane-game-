using UnityEngine;

public class Boxdestroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) //When a 2D object contacts the trigger (ie one of the boxes)
    {
        Destroy(collision.gameObject); //The box will be deleted on contact
    }
}

//I would've liked to add a system where boxes can only go into the pipes that have the same colour as them,
//but it might be too complicated, and since the only moving game objects are the boxes, I just settled
//on each pipe deleting whateever enters it, regardless if its the wrong colour or not