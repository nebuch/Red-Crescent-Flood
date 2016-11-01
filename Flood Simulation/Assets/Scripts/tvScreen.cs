using UnityEngine;
using System.Collections;

public class tvScreen : MonoBehaviour {

	public Material _tVScreenMat;
	public Collider _remoteController;

	public bool _targeted;

	[Header ("Textures")]

	public Texture _dummy;


	// Use this for initialization
	void Start () {

		_tVScreenMat.mainTexture = null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
	
		if (other == _remoteController) {
		
			_targeted = true;
		
		}	
	}

	void OnTriggerExit(Collider other){

		if (other == _remoteController) {

			_targeted = false;

		}	
	}

	public void TvOn(){
		Debug.Log ("TvOn called");
		if (_targeted) {
			Debug.Log ("Targeted");
			_tVScreenMat.mainTexture = _dummy;
		}
	
	}

}
