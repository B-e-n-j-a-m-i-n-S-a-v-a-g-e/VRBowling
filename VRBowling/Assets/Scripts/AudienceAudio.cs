using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
