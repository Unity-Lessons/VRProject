using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour {

    public int speed = 0;
    float moveHorizontal = 1.0f;
    float moveVertical = 1.0f;

    // Use this for initialization
    void Start () {

        Vector3 position = transform.position;      // this transform
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        transform.position = position;
    }

}
