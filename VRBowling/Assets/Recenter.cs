using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recenter : MonoBehaviour {

	public Transform VRcam;  // drag the child VR cam here in the inspector

	void Start () {
		ReCenter ();
	}

	void Update () {
		
	}

	public void ReCenter()
	{
		transform.localRotation = Quaternion.identity;
	}
}
	