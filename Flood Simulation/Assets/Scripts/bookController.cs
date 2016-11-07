using UnityEngine;
using System.Collections;

public class bookController : MonoBehaviour {

	public int _bookType;

	public Collider _bookCover;

	public bool _bookOpen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void BookOpen(){
	
		_bookOpen = true;
	
	}

	void OnTriggerEnter(Collider other){
	
		if (other == _bookCover) {
		
			BookOpen ();

		}
	
	}
}
