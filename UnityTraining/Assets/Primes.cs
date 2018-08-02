using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FindPrimes (246);
	}

	List<int> FindPrimes(int num) {

		List<int> factors = new List<int> ();
		int i = 2;

		while (i < num) {

			while (num % i == 0) { 

				factors.Add (i);

				num = num / i;
			}
			i++;
		}

		if (num > 1) {
			factors.Add (num);
		}

		for (int j = 0; j < factors.Count; j++) {
			Debug.Log(factors [j]);
		}

		return factors;
	}
}
