using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSelectionController : MonoBehaviour {

	private string currentBall;
	private bool isShowingTitle = false;

	void Start () {

		StartCoroutine ("MoveCamera");
	}

	void Update () {

		if (isShowingTitle) {

			if (Camera.main.gameObject.transform.rotation.y <= 0.0f) {
				
				Debug.Log (Camera.main.gameObject.transform.rotation.y);
				Camera.main.gameObject.transform.Rotate (0, 0.2f, 0);
			} else if (Camera.main.gameObject.transform.rotation.y <= 0.0f) {  
				
				GameObject.Find ("IntroScreenText").SetActive (true);
				GameObject.Find ("TitleText").SetActive (false);
			}
				
			if (Input.GetMouseButtonDown (0)) {
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.name == "FieriBall") {
						currentBall = "FieriBall";
						SceneManager.LoadScene ("Gameplay");
					}
				}
			}
		} else {
			GameObject.Find ("IntroScreenText").SetActive (false);
			GameObject.Find ("TitleText").SetActive (true);
		}
	}

	IEnumerator MoveCamera() {

		yield return new WaitForSeconds (3.0f);
		isShowingTitle = true;
	}
}
