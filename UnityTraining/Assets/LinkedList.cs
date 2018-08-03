using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell {

	public string Value;
	public Cell Next;
}

public class LinkedList {

	private Cell head;

	public void AddElementAtBeginning(string value) { //("hello") -> ("world") -> head

		Cell newCell = new Cell ();
		newCell.Value = value;
		newCell.Next = head;

		head = newCell;
	}

	public void PrintOutElements() {

		Cell current = head;

		while (current != null) {

			Debug.Log (current.Value);
			current = current.Next;
		}
	}
}
