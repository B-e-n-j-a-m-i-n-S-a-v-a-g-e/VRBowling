using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {


	public GameObject BowlingBall;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTouchFloor() {

		BowlingBall.GetComponent<AudioSource> ().Stop ();
		Destroy (gameObject);
		explosion.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		Instantiate (explosion, new Vector3 (transform.position.x, transform.position.y - 1.0f, transform.position.z), Quaternion.identity);
	}
}
