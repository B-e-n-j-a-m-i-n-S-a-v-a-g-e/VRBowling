using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recenter : MonoBehaviour {

	public Transform VRcam;  // drag the child VR cam here in the inspector

	// Use this for initialization
	void Start () {
		ReCenter ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ReCenter()
	{
		transform.localRotation = Quaternion.identity;
	}
}
	