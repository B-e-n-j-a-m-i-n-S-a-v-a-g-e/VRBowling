using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLL : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		LinkedList ll = new LinkedList ();
		ll.AddElementAtBeginning ("cat");
		ll.AddElementAtBeginning ("dog");
		ll.AddElementAtBeginning ("bird");
		ll.AddElementAtBeginning ("giraffe");
		ll.PrintOutElements ();
	}

}
