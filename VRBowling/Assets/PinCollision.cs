﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollision : MonoBehaviour {

	public Pin pin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.tag == "floor") {
			pin.OnTouchFloor ();
		}
	}
}
