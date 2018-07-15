using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject BowlingBall;
	public GameObject Arrow;
	public float ballDistance = 2.5f;
	public float arrowDistance = 2.5f;

	public bool holding = true;
	public float ballThrowingForce = 200.0f;

	void Start () {
		
	}

	void Update () {

		if (holding) {
			BowlingBall.transform.position = transform.position + Camera.main.transform.forward * ballDistance;
			Arrow.transform.position = transform.position + 
				new Vector3(0.0f, BowlingBall.transform.position.y - 4.3f, BowlingBall.transform.position.z);

			Arrow.transform.eulerAngles = new Vector3 (0.0f, transform.eulerAngles.y, 0.0f);

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
