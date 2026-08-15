using UnityEngine;

public class Grabscript : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float minRotation = -45f;
    public float maxRotation = 45f;
    Rigidbody2D Lclaw;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lclaw = GameObject.Find("Left claw").GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 0f;
        float currentRotation = transform.eulerAngles.z; //Get the current Z rotation

        if (Input.GetKey(KeyCode.G))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }

        // Convert 0-360° into -180° to 180°
        if (currentRotation > 180f)
            currentRotation -= 360f;

        // Clamp the rotation
        currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);

        transform.rotation = Quaternion.Euler(0, 0, currentRotation);

    }
}
