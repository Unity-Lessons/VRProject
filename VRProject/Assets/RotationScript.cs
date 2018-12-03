using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    public float verticalSpinSpeed = 60.0f;
    public float horizontalSpinSpeed = 60.0f;
    public float sideSpinSpeed = 60.0f;

    // Update is called once per frame
    void Update () {

        // Set position and rotation to match the camera
        //gameObject.transform.parent = Camera.main.transform;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(verticalSpinSpeed * Time.deltaTime, 0, 0, Space.World);
        }
        else if(Input.GetKey(KeyCode.S))
        {
                transform.Rotate(-verticalSpinSpeed * Time.deltaTime, 0, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, horizontalSpinSpeed * Time.deltaTime, 0, Space.World);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -horizontalSpinSpeed * Time.deltaTime, 0, Space.World);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -sideSpinSpeed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, sideSpinSpeed * Time.deltaTime, Space.World);
        }
    }
}
