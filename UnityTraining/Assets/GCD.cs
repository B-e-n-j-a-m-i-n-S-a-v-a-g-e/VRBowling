using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (FindGCD (4851, 3003));
	}

	int FindGCD(int a, int b) { 

		while (b != 0) {

			int remainder = a % b; 

			a = b;
			b = remainder;
		}

		return a;
	}

}
