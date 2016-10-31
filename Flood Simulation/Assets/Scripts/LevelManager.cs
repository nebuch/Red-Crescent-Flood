using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    public GameObject[] m_Scenes;
    private int m_CurrentSceneIndex = 0;
    
    void Start() {
        SetInitialScenes();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            ActivateNextLevel();
        }
	}

    //Load next level when certain conditions are met
    public void ActivateNextLevel() {
        GameObject nextLevel = m_Scenes[m_CurrentSceneIndex++];
        foreach (GameObject scene in m_Scenes) {
            scene.SetActive(false);
            if (scene == nextLevel) {
                scene.SetActive(true);
            }
        }
    }

    private void SetInitialScenes() {
        GameObject m_InitialScene = m_Scenes[m_CurrentSceneIndex];
        foreach (GameObject scene in m_Scenes) {
            scene.SetActive(false);
            if (scene == m_InitialScene) {
                scene.SetActive(true);
            }
        }
    }

    private int GetCurrentSceneIndex()
    {
        return m_CurrentSceneIndex;
    }
}
