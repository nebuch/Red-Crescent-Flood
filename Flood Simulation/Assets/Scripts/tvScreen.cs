using UnityEngine;
using System.Collections;

public class tvScreen : MonoBehaviour {

	public Material _tVScreenMat;
	public Collider _remoteController;

	public bool _targeted;

	public bool _controlButton;

	[Header ("Textures")]

	public MovieTexture _dummy;


	// Use this for initialization
	void Start () {

		_tVScreenMat.mainTexture = null;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (_controlButton) {
		
			TvOn ();
			_controlButton = false;
		
		}

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
		if (_targeted || _controlButton) {
			Debug.Log ("Targeted");
			_tVScreenMat.mainTexture = _dummy;
			_dummy.loop = true;
			_dummy.Play ();
			_controlButton = false;
		}
	
	}

}
