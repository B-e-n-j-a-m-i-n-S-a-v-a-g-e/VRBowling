using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Player player;
	public GameObject VRPlayer;
	public TextMesh infoText;
	public GameObject strikeText;
	public Pin[] pins;
	public GameObject BowlingBall;
	public GameObject Audience;
	public GameObject camera;
	private int numTurns = 0;
	private int score; 

	public float evaluationTime = 10.0f;

	private float gameTimer = 0.0f;
	private bool evaluating = false;

	void Update () {
		infoText.text = "";
		Debug.Log ("game timer " + gameTimer);
		if (!evaluating) {
			if (!player.holdingBall) {
				evaluating = true;
				gameTimer = evaluationTime;
			}
		} else {
			gameTimer -= Time.deltaTime;
			if (gameTimer <= 3.0f) {
				score = 0;

				for (int i = 0; i < pins.Length; i++) {
					if (pins [i] == null) {
						score++;
					}
				}
				strikeText.gameObject.SetActive (true);
				camera.gameObject.SetActive (false);
				Audience.SetActive (true);
				Audience.transform.GetChild(0).GetComponent<Animation>().Play("applause");
				Audience.transform.GetChild(1).GetComponent<Animation>().Play("celebration2");
				Audience.transform.GetChild(2).GetComponent<Animation>().Play("applause");
				Audience.transform.GetChild(3).GetComponent<Animation>().Play("celebration");
				Audience.transform.GetChild(4).GetComponent<Animation>().Play("applause");
		

				//infoText.text = "Your score: " + score;

				StartCoroutine ("ResetBall");

			}
		}
	}
		
	public IEnumerator ResetBall() {
		yield return new WaitForSeconds (3.0f);

		strikeText.gameObject.SetActive (false);
		camera.gameObject.SetActive (true);
		Audience.SetActive (false);

		if (gameTimer <= 0.0f) {
			BowlingBall.transform.position = new Vector3 (-1.25f, 2.16f, 3.34f);
			VRPlayer.transform.position = new Vector3 (0, 2.97f, 7.92f);
			gameTimer = 10.0f;
			player.holdingBall = true;
			evaluating = false;

			if (numTurns < 1 && score != 10) {
				numTurns++;
			} else {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			}

		}
	}
}
