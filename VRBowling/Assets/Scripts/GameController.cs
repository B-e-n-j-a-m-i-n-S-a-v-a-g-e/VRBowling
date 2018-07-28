using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Player player;
	public GameObject VRPlayer;
	public TextMesh infoText;
	public Pin[] pins;
	public GameObject BowlingBall;
	private int numTurns = 0;
	private int score; 

	public float evaluationTime = 10.0f;

	private float gameTimer = 0.0f;
	private bool evaluating = false;

	// Update is called once per frame
	void Update () {
		infoText.text = "";

		if (!evaluating) {
			if (!player.holding) {
				evaluating = true;
				gameTimer = evaluationTime;
			}
		} else {

			gameTimer -= Time.deltaTime;
			if (gameTimer <= 0.0f) {
				score = 0;

				for (int i = 0; i < pins.Length; i++) {
					if (pins [i] == null) {
						score++;
					}
				}

				infoText.text = "Your score: " + score;
			}

			if (gameTimer <= -3.0f) {
				BowlingBall.transform.position = new Vector3 (-1.25f, 2.16f, 3.34f);
				VRPlayer.transform.position = new Vector3 (0, 2.97f, 7.92f);
				player.holding = true;
				evaluating = false;

				if (numTurns < 1 && score != 10) {
					numTurns++;
				} else {
					SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
				}

			}
		}
	}
}
