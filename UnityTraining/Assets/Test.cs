using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour {


	public GameObject myPrefab;


	void Start() {

		InstantiatePrefab();
	}

	void InstantiatePrefab() {
		Instantiate (myPrefab, new Vector3(10,10,10),Quaternion.identity);
	}


}

