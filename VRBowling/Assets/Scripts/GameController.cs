using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Player player;
	public TextMesh infoText;
	public Pin[] pins;
	public GameObject BowlingBall;
	private int numTurns = 0;

	public float evaluationTime = 10.0f;

	private float gameTimer = 0.0f;
	private bool evaluating = false;

	// Update is called once per frame
	void Update () {
		infoText.text = "throw the ball.";

		if (!evaluating) {
			if (player.holding == false) {
				evaluating = true;
				gameTimer = evaluationTime;
			}
		} else {

			gameTimer -= Time.deltaTime;
			if (gameTimer <= 0.0f) {
				int score = 0;

				for (int i = 0; i < pins.Length; i++) {
					if (pins [i] == null) {
						score++;
					}
				}

				infoText.text = "Your score: " + score;
			}

			if (gameTimer <= -3.0f) {
				BowlingBall.transform.position = new Vector3 (-1.25f, 2.16f, 3.34f);
				player.holding = true;
				evaluating = false;

				if (numTurns < 1) {
					numTurns++;
				} else {
					SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
				}

			}
		}
	}
}
