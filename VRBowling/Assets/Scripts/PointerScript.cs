using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision col) {

		/*
		Debug.Log (col.gameObject.name);

		switch(col.gameObject.name)
		{
		case "FieriBall":
			Debug.Log ("Fieri collision");
			break;
		case "StripeBall":
			Debug.Log ("Stripe collision");
			break;
		case "OrangeBall":
			Debug.Log ("Orange collision");
			break;
		case "PurpleBall":
			Debug.Log ("Purple collision");
			break;
		}
		*/
	}
}
