using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public GameObject BowlingBall;
	public GameObject Arrow;
	public float ballDistance = 2.5f;
	public float arrowDistance = 2.5f;

	public bool holding = true;
	public float ballThrowingForce = 200.0f;

	public float rotationLimit = 10f; // Rotation limit in either direction

	private Image blackout;

	void Start () {
		blackout = GetComponentInChildren<Image>();
	}

	void Update () {

		float cameraRotationY = transform.localRotation.eulerAngles.y;


		if (cameraRotationY >= rotationLimit && cameraRotationY < (360-rotationLimit)) {
			blackout.color = Color.clear;
		} else {
			blackout.color = Color.black;
		}

		if (holding) {

			BowlingBall.GetComponent<Rigidbody> ().isKinematic = false;
			BowlingBall.transform.position = transform.position + Camera.main.transform.forward * ballDistance;
			Arrow.transform.position = transform.position +
			new Vector3 (0.0f, BowlingBall.transform.position.y - 2.3f, BowlingBall.transform.position.z);

			Arrow.transform.eulerAngles = new Vector3 (0.0f, transform.eulerAngles.y, 0.0f);

			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began || Input.GetKeyDown ("space")) {
				holding = false;
				BowlingBall.GetComponent<AudioSource> ().Play ();
			}

		} else {
			BowlingBall.GetComponent<Rigidbody> ().useGravity = true;
			BowlingBall.GetComponent<Rigidbody> ().AddForce (transform.forward * 1000);
		}

		if (BowlingBall.transform.position.y < -1.4) {
			BowlingBall.GetComponent<Rigidbody> ().isKinematic = true;
		}

		transform.position = new Vector3 (transform.position.x, 2.0f, transform.position.z);

	}
}
