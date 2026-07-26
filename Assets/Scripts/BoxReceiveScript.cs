using System;
using UnityEngine;

public class Boxreceivescript : MonoBehaviour
{
    //public BoxCounter boxcounter;

    public static Action<int> OnCollectableCollected;

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            OnCollectableCollected?.Invoke(1);
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {

    }
}
