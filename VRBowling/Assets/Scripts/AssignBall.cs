using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignBall : MonoBehaviour {

	private BallType bt;
	private Material ballMaterial;

	// Use this for initialization
	void Start () {
		
		//Debug.Log ("BALL TYPE " + bt.ballType);
		ballMaterial = GetComponent<MeshRenderer> ().material;
		Debug.Log (ballMaterial);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
