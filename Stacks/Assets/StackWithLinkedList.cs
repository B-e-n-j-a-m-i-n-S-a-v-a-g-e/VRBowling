using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell {


	public Cell Next;
	public string Value;
}

public class Stack {

	private Cell head;

	public void Push(string value) {

		Cell newCell = new Cell ();
		newCell.Value = value;

		newCell.Next = head;
		head = newCell;
	}

	public string Pop() {

		if (head == null) {
			return null;
		}

		Cell result = head.Next;

		if (head.Next.Next) {
			head.Next = head.Next.Next;
		} else {
			head = null;
		}

		return result.Value;
	}

	public void PrintOutElements() {

		Cell current = head;

		while (current != null) {

			Debug.Log (current.Value);
			current = current.Next;
		}

	}
}
