using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject BowlingBall;
	public float ballDistance = 2.5f;

	private bool holding = true;
	public float ballThrowingForce = 200.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (holding) {
			BowlingBall.transform.position = transform.position + Camera.main.transform.forward * ballDistance;

			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began || Input.GetKeyDown ("space")) {
				holding = false;
				BowlingBall.GetComponent<Rigidbody> ().useGravity = true;
				BowlingBall.GetComponent<Rigidbody> ().AddForce (transform.forward * ballThrowingForce);
			}
		}

		if (BowlingBall.transform.position.y < -10) {
			BowlingBall.transform.position = new Vector3 (0, 2, 5);
			holding = true;
		}

	}
}
