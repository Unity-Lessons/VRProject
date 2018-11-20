using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        
        // Set position and rotation to match the camera
        gameObject.transform.parent = Camera.main.transform;
	}
}
