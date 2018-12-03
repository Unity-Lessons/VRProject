using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour {

    float spinSpeed = 1.0f;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

        if (transform.eulerAngles.y == 90.0)
        {
            spinSpeed = 50.0f;
            print(transform.eulerAngles.y);
        }    
        else if (transform.eulerAngles.y == -30.0)
            spinSpeed = 5.0f;
    }
}
