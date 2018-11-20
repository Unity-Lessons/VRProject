using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    public float tiltSpeed = 0.0f;
    public float tiltAngle = 120.0f;
    public int rotationAmount = 20;
	
	// Update is called once per frame
	void Update () {
        float tiltOnY = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltOnX = Input.GetAxis("Vertical") * tiltAngle;

        Quaternion rotation = Quaternion.Euler(tiltOnX, tiltOnY, 0);
        gameObject.transform.parent = Camera.main.transform;
        Transform cameraRotation = transform.parent;

        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * tiltSpeed);
        
        
	}
}
