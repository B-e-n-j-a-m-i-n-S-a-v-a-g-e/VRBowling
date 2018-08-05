using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSelectionController : MonoBehaviour {

	private string currentBall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.name == "FieriBall") {
					Debug.Log ("ok.");
					currentBall = "FieriBall";
					SceneManager.LoadScene ("Gameplay");
				}
			}
		}
	}
}
