using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallRotation : MonoBehaviour {

	void Start () {
		
	}

	void Update () {

		if (SceneManager.GetActiveScene().name == "BallSelectionScreen") {
			transform.Rotate (Vector3.up * Time.deltaTime * -22.00f, Space.World);
		}
	}
}
