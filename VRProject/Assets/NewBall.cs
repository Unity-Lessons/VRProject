using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBall : MonoBehaviour {

    public GameObject myBall;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other);

        myBall.transform.position = spawnPoint.position;
        Instantiate(myBall);
    }
}
