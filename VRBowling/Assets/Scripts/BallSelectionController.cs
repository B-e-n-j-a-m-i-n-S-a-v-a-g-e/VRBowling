using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallSelectionController : MonoBehaviour {

	private string currentBall;
	public BallType bt;
	private bool isShowingTitle = false;
	public GameObject text;
	public GameObject selectBallText;
	public GameObject pointer;

	void Start () {

		StartCoroutine ("MoveCamera");
	}

	void Update () {

		if (isShowingTitle) {

			if (Camera.main.gameObject.transform.rotation.y <= 0.0f) {
				
				Camera.main.gameObject.transform.Rotate (0, 0.3f, 0);
			} else if (Camera.main.gameObject.transform.rotation.y > 0.0f) {  

				selectBallText.SetActive (true);
				//pointer.gameObject.SetActive (true);
				StartCoroutine(FadeTextToZeroAlpha(1f, text.GetComponent<Text>()));
			}
				
			if (Input.GetMouseButtonDown (0)) {

				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.name == "FieriBall") {
						bt.ballType = "FieriBall";
						SceneManager.LoadScene ("Gameplay");
					}
					else if (hit.transform.name == "StripeBall") {
						bt.ballType = "StripeBall";
						SceneManager.LoadScene ("Gameplay");
					}
					else if (hit.transform.name == "OrangeBall") {
						bt.ballType = "OrangeBall";
						SceneManager.LoadScene ("Gameplay");
					}
					else if (hit.transform.name == "PurpleBall") {
						bt.ballType = "PurpleBall";
						SceneManager.LoadScene ("Gameplay");
					}
				}
			}
		} else {
	
			//pointer.gameObject.SetActive (true);
			Debug.Log ("am I here?");
			if (Input.GetMouseButtonDown (0)) {


				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.name == "FieriBall") {
						currentBall = "FieriBall";
						SceneManager.LoadScene ("Gameplay");
					}	
					else if (hit.transform.name == "StripeBall") {
						bt.ballType = "StripeBall";
						SceneManager.LoadScene ("Gameplay");
					}
					else if (hit.transform.name == "OrangeBall") {
						bt.ballType = "OrangeBall";
						SceneManager.LoadScene ("Gameplay");
					}
					else if (hit.transform.name == "PurpleBall") {
						bt.ballType = "PurpleBall";
						SceneManager.LoadScene ("Gameplay");
					}
				}
			}
		}
	}

	IEnumerator MoveCamera() {

		yield return new WaitForSeconds (3.0f);
		isShowingTitle = true;
	}

	IEnumerator FadeTextToZeroAlpha(float t, Text i)
	{
		i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
		while (i.color.a > 0.0f)
		{
			i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
			yield return null;
		}
		isShowingTitle = false;
		yield return null;
	}


}
