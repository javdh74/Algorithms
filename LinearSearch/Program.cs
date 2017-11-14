using System;

namespace LinearSearch {
	class Program {
		static void Main(string[] args) {
			const int value = 9;
			int index = 0;
			int[] sequence = new int[] { 5, 2, 4, 6, 1, 3 };
			index = LinearSearch(sequence, value);
			if (index == sequence.Length)
				Console.WriteLine("Value not found");
			else
				Console.WriteLine(index);			
		}
		static int LinearSearch(int[] sequence, int value) {
			int index = 0;
			for (int i = 0; i < sequence.Length; i++) {
				index = i;
				if (sequence[index] == value)
					return index;
			}
			return ++index;
		}
	}
}