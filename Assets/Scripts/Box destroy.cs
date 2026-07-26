using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxdestroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Collectable"))
        //{
            Destroy(collision.gameObject);
           // Boxcounter.instance.AddPoint();
        //}
    }
}
