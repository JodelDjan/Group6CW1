using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    

    public float speed = 0.0f;
    public float maxSpeed = 20.0f;
    public float acc = 5.0f;
    public float dec = 5.0f;
    public float rotationSpeed = 1.0f; 

    
    void Update()
    {
        
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
       

        else if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
        }
        

        else
        {
            speed = 0;
        }

        


        if (speed != 0)
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0); 
        }
        



        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0); 
        }
    }
}
