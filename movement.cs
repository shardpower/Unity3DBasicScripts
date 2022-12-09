using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Initialize movement speed
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the new position based on the input axes and the speed
        Vector3 newPosition = transform.position + new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;

        // Update the object's position
        transform.position = newPosition;
    }
}
