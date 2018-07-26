using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCameraChange : MonoBehaviour {

	public GameObject player;
	public GameObject whiteImage;

	void OnTriggerEnter(Collider collider) {
		whiteImage.SetActive (false);

		if (collider.tag == "Ball") {
			player.transform.position = new Vector3 (-0.1f, -0.26f, 22.39f);
		}
	}
}
