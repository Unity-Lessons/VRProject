using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {


    public float speed = 5.0f;

    private void OnTriggerStay(Collider other)
    {
        var direction = -(other.attachedRigidbody.transform.position - transform.position);
        if (other.attachedRigidbody)
            other.attachedRigidbody.AddForce(direction * speed); 
    }

}
