using UnityEngine;
using System.Collections;

public class tvRemoteController : MonoBehaviour {
	public NewtonVR.NVRHand _newtonScript;
	public bool _interactWithRemote;
	public GameObject _tvRemoteObject;
	public NewtonVR.NVRInteractable _tvRemoteInteractable;
	[Header ("remote's meshes")]

	public MeshRenderer _remoteBodyMesh;
	public MeshRenderer _remoteButtonMesh;

	[Header("hand")]

	public NewtonVR.NVRHand _thisHand;

	public GameObject _handModel;
	public GameObject _remoteInHand;
	[Header("hand")]
	public tvScreen _tvScreen;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (_newtonScript.CurrentlyInteracting == _tvRemoteInteractable && !_interactWithRemote) {
			_interactWithRemote = true;
			_remoteBodyMesh.enabled = false;
			_remoteButtonMesh.enabled = false;
			_handModel.SetActive (false);
			_remoteInHand.SetActive (true);
		
		}

		if (_interactWithRemote) {
			Debug.Log ("Entered into interact with remote");
			if (_newtonScript.PadButtonPressed) {
				Debug.Log ("PadButtonPressed");
				_tvScreen.TvOn ();

			}
		}

		if (_tvRemoteObject.GetComponent<NewtonVR.NVRInteractableItem>().AttachedHand != _thisHand) {

			_interactWithRemote = false;

			_remoteBodyMesh.enabled = true;
			_remoteButtonMesh.enabled = true;
			_handModel.SetActive (true);
			_remoteInHand.SetActive (false);

		}

	}
}
