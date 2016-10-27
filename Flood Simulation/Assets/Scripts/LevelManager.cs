using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {


    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
        Debug.Log("Number of scenes in build settings: " + SceneManager.sceneCountInBuildSettings);
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.sceneCountInBuildSettings < 5)
            Debug.LogError("Please add all the scenes into build settings");

        LoadNextLevel();
	}

    //Load next level when certain conditions are met
    void LoadNextLevel() {
        if (Input.GetKeyDown(KeyCode.Return)) {     //TODO: Remove this line later
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
