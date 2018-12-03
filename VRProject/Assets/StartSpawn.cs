using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject myBall;

    void Start()
    {
        myBall.transform.position = spawnPoint.position;
        Instantiate(myBall);
    }
}
