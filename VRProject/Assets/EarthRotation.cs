﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour {

    public float spinSpeed = 5.0f;

    // Update is called once per frame
    void Update () {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
