using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Pin : MonoBehaviour {


	public GameObject BowlingBall;
	public GameObject explosion;

	public AudioClip pinsDown;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().clip = pinsDown;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTouchFloor() {

		BowlingBall.GetComponent<AudioSource> ().Stop ();
		GetComponent<AudioSource> ().Play ();

		//GetComponent<MeshExploder> ().Explode ();
		StartCoroutine ("DestroyPin");
		//explosion.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		//Instantiate (explosion, new Vector3 (transform.position.x, transform.position.y - 1.0f, transform.position.z), Quaternion.identity);

	}

	IEnumerator DestroyPin() {
		yield return new WaitForSeconds (0.5f);
		Destroy (gameObject);
	}
}
