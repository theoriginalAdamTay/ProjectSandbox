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

		public void FindBlankIndex(List<int> list) { // Method for finding blank list indices
			list.Sort(); // Sort the list specified in arguments in ascending order
			for (int i = 1; i <= list.Count; i++) { // For each list index, from 1 until the last index, execute code below
				if (!list.Contains(i)) { // If list index i is missing execute code below
					return i; // Return list index i
				}
				else { // If no list indices are missing execute code below
					return list[list.Count - 1] + 1; // Return next index in the list
				}
			}
		}
	}
}
