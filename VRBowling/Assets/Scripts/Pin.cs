using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {


	public GameObject BowlingBall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTouchFloor() {

		BowlingBall.GetComponent<AudioSource> ().Stop ();
		Destroy (gameObject);
	}
}
