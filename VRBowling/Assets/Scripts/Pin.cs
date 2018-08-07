using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Pin : MonoBehaviour {


	public GameObject BowlingBall;
	public AudioClip pinsDown;

	void Start () {
		GetComponent<AudioSource> ().clip = pinsDown;
	}

	public void OnTouchFloor() {

		BowlingBall.GetComponent<AudioSource> ().Stop ();
		GetComponent<AudioSource> ().Play ();
		StartCoroutine ("DestroyPin");
	}

	IEnumerator DestroyPin() {
		yield return new WaitForSeconds (0.5f);
		Destroy (gameObject);
	}
}
