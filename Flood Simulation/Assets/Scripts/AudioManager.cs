using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip[] turkishAudio;
    public AudioClip[] englishAudio;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
