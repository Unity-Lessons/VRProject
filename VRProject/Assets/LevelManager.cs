using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    int currentSceneIndex;

    // Use this for initialization
    void Start () {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
            SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
