using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    // Declare float variables for speed, max speed, acceleration, deceleration, and rotation speed

    public float speed = 0.0f;
    public float maxSpeed = 20.0f;
    public float acc = 5.0f;
    public float dec = 5.0f;
    public float rotationSpeed = 1.0f; // Slower rotation speed

    // Update is called once per frame
    void Update()
    {
        // Only adjust speed if W or S is pressed
        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed)
                speed += acc * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (speed > -maxSpeed)
                speed -= acc * Time.deltaTime;
        }
        // Stop movement if Space is pressed
        else if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
        }
        // No keys pressed: set speed to zero to prevent any movement at the start
        else
        {
            speed = 0;
        }

        // Move the character forward or backward based on the current speed
        if (speed != 0)
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        // Rotate left when "A" is pressed
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0); // Rotate left
        }
        // Rotate right when "D" is pressed
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0); // Rotate right
        }
    }
}
