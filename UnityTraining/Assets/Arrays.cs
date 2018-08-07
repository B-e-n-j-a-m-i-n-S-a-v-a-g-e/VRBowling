using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {


	int[] myArray = { 6, 2, 8, 11, 1, 2, 48, 3 };

	void Start () {
		Debug.Log (FindMinimum (myArray));
	}

	int FindMinimum(int[] array) {

		int minimum = array [0];

		for (int i = 0; i < array.Length; i++) {

			if (array [i] < minimum) {
				minimum = array [i];
			}
		}
		return minimum;
	}

	int FindMaximum(int[] array) {

		int maximum = array [0];

		for (int i = 0; i < array.Length; i++) {

			if (array [i] > maximum) {
				maximum = array [i];
			}
		}

		return maximum;
	}

	float FindAverage(int[] array) {

		int total = 0;

		for (int i = 0; i < array.Length; i++) {
			total += array [i];
		}

		return total / array.Length;
	}
		
}
