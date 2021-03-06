﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Pin : MonoBehaviour {


	public GameObject BowlingBall;
	public AudioClip pinsDown;
	public GameObject explosion;
	public GameObject innerExplosion;

	void Start () {
		GetComponent<AudioSource> ().clip = pinsDown;
	}

	public void OnTouchFloor() {

		Debug.Log ("getting here?");
		BowlingBall.GetComponent<AudioSource> ().Stop ();
		this.GetComponent<AudioSource> ().Play ();
		StartCoroutine ("DestroyPin");
		//DestroyPin ();
	}

	IEnumerator DestroyPin() {
		yield return new WaitForSeconds (0.3f);
		Instantiate (explosion, new Vector3(transform.position.x - 0.8f, transform.position.y, transform.position.z), Quaternion.identity);
		Instantiate (innerExplosion, new Vector3(transform.position.x - 0.8f, transform.position.y, transform.position.z), Quaternion.identity);
		Destroy (gameObject);

	}
}
