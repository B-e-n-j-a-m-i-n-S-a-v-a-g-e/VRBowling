using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceAnimate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void PlayAnimation() {
		GetComponent<Animation> ().Play ();	
	}

}
