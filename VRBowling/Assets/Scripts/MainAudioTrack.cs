using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAudioTrack : MonoBehaviour {

	static MainAudioTrack instance  = null;

	void Awake () {

		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
	}

	void Start() {

		if (!GetComponent<AudioSource> ().isPlaying) {
			GetComponent<AudioSource> ().Play ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
