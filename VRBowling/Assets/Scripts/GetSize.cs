using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(GetComponent<Collider>().bounds.size);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
