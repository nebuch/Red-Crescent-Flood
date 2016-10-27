using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {


    void Awake() {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Test if DontDestroyOnLoad() works
        if (Input.GetKeyDown(KeyCode.Return)) {     //TODO: Remove this line later 
            LoadNextLevel();
        }
	}

    //Load next level when certain conditions are met
    void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
