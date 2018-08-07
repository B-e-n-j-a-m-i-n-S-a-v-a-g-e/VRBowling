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

	public Cell FindCell(string value) {

		Cell current = head;

		while (current.Next != null) {

			if (current.Value == value) {
				return current;
			}

			current = current.Next;
		}

		return null;
	}
		
	public void RemoveElementAfterValue(string value) { //(a)->(b)->(c)

		Cell current = head;

		while (current.Next.Next != null) {

			if (current.Value == value) {

				current.Next = current.Next.Next;
			}
			current = current.Next;
		}
	}

	public void PrintOutElements() {

		Cell current = head;

		while (current != null) {

			Debug.Log (current.Value);
			current = current.Next;
		}
	}


	/*
	public void RemoveElementAfterValue(string value) {

		Cell current = head;

		while (current.Next.Next != null) {

			if (current.Value == value) {
				current.Next = current.Next.Next;
			}

			current = current.Next;
		}
	}
	*/
}
