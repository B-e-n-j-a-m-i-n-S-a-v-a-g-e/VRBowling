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

	public void AddElementAfterValue(string searchedValue, string value) {

		Cell current = head;
		Cell newCell = new Cell ();
		newCell.Value = value;

		while (current != null) {

			if (current.Value == searchedValue) { //(a) -> (b) -> (d) -> (c)   

				newCell.Next = current.Next;
				current.Next = newCell;
			}
			current = current.Next;
		}
	}

	public void AddElementAtEnd(string value) { // (a) -> (b) -> (c)

		Cell current = head;
		Cell newCell = new Cell ();
		newCell.Value = value;

		while (current.Next != null) {

			current = current.Next;
		}

		current.Next = newCell;
		newCell.Next = null;
	}


	public void PrintOutElements() {

		Cell current = head;

		while (current != null) {

			Debug.Log (current.Value);
			current = current.Next;
		}
	}
	/*
	public void AddElementAfterValue(string searchValue, string value) {

		Cell current = head;
		Cell newCell = new Cell ();
		newCell.Value = value;

		while (current != null) {
			if (current.Value == searchValue) {
				newCell.Next = current.Next;
				current.Next = newCell;
			}
			current = current.Next;
		}
	} */
}
