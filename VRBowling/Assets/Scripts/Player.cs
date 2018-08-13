using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public GameObject BowlingBall;
	public ParticleSystem ps;

	public float ballDistance = 2.5f;
	public float ballThrowingForce = 200.0f;

	public bool holdingBall = true;

	public float rotationLimit = 10f; // Camera rotation limit in either direction
	private Image blackout;

	void Start () {
		blackout = GetComponentInChildren<Image>();
		BowlingBall.GetComponent<ParticleSystem>().enableEmission = false;
	}

	void Update () {

		ManageCameraRotation ();
	
		if (holdingBall) {

			BowlingBall.GetComponent<Rigidbody> ().isKinematic = false;
			BowlingBall.transform.position = transform.position + Camera.main.transform.forward * ballDistance;

			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began || Input.GetKeyDown ("space")) {
				holdingBall = false;
				BowlingBall.GetComponent<AudioSource> ().Play ();
			}

		} else {
			
			BowlingBall.GetComponent<Rigidbody> ().useGravity = true;
			BowlingBall.GetComponent<Rigidbody> ().AddForce (transform.forward * 1000);

			if (BowlingBall.transform.position.y < 0.95f && BowlingBall.transform.position.x <= 180.0f ) {
				ps.Play ();
			}

			if (BowlingBall.transform.position.x > 180.0f) {
				ps.Stop ();
			}
		}

		if (BowlingBall.transform.position.y < -1.4) {
			BowlingBall.GetComponent<Rigidbody> ().isKinematic = true;
		}
	}

	void ManageCameraRotation() {

		float cameraRotationY = transform.localRotation.eulerAngles.y;

		if (cameraRotationY >= rotationLimit && cameraRotationY < (360-rotationLimit)) {
			blackout.color = Color.clear;
		} else {
			blackout.color = Color.black;
		}
	}
}
