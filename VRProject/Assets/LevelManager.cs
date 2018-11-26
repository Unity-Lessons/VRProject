using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    int currentSceneIndex;
    public AudioSource transport;
    public int frame;

    // Use this for initialization
    void Start () {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            Debug.Log("Touched the butt");
            transport.Play();
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

}
