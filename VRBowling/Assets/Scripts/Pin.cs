using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTouchFloor() {

		if (GetComponent<AudioSource> ()) {
			GetComponent<AudioSource>().Play ();
		}
		Destroy (gameObject);
	}
}
