using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayBlankFiller {
	public ArrayBlankFiller() {
		public static void Main(String[] args) { // Main method
			List<int> numberList = new List<int>(); // Define list of integers
		}

		public void DelistAndRedefine(List<int> list, int delistElement) { // Method for redefining list indices
			list.Remove(delistElement); // Remove element from list specified in arguments
			for (int i = 0; i < list.Count; i++) { // For each list index execute code below
				list[i] = i + 1; // Redefine list indices
			}
		}
	}
}
