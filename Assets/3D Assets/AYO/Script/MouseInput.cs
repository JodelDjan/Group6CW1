using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    //PSEUDO CODE: Declare public variable of type float for speed;

    public float speed = 50.0f;

    void Update()
    {

    }
    void OnMouseDrag()
    {
        //TRY:
        // Declare and Initialize the X and Y mouse axes and multiply by speed.
        // The value is in the range -1 to 1
        //Mouse Y will become Z translation

        float transX = Input.GetAxis("Mouse X") * speed;
        float transZ = Input.GetAxis("Mouse Y") * speed;

        // Make translation variable move at 10 meters per second instead of 10 meters per frame with TimeDeltaTime...

        transX *= Time.deltaTime;
        transZ *= Time.deltaTime;

        // use transform to translate with values above
        
        transform.Translate(transX, 0, transZ);

        //Try Stretch Task in tutorial sheet

        // Calculate distance from camera to object
        float distance_To_Screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Convert mouse position to world coordinates
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_To_Screen));

        // Set the object's position
        transform.position = new Vector3(pos_move.x, transform.position.y, pos_move.z);
    }

}
