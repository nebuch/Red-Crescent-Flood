using UnityEngine;
using System.Collections;

public class handMovement : MonoBehaviour {

	public Transform _controllerPosition;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = _controllerPosition.position;
		this.transform.rotation = _controllerPosition.rotation;
	}
}
