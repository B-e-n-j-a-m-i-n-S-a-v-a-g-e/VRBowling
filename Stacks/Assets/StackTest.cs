using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Stack stack = new Stack ();
		stack.Push ("booger");
		stack.Push ("snot");
		stack.PrintOutElements ();
		stack.Pop ();
		stack.PrintOutElements ();
		stack.Pop ();
		stack.PrintOutElements ();
	}

}
