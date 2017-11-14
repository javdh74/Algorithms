using System;

namespace InsertionSort {
	class Program {
		static void Main(string[] args) {
			Increasing();
			Decreasing();
		}
		static void Increasing() {
			int[] A = new int[] { 5, 2, 4, 6, 1, 3 };
			int j = 0, key = 0;
			for (int i = 1; i < A.Length; i++) {
				key = A[i];
				j = i - 1;
				while (j >= 0 && A[j] > key) {
					A[j + 1] = A[j];
					j--;
				}
				A[j + 1] = key;
			}
			for (int i = 0; i < A.Length; i++)
				Console.Write("{0} ", A[i]);
			Console.WriteLine();
		}
		static void Decreasing() {
			int[] A = new int[] { 5, 2, 4, 6, 1, 3 };
			int j = 0, key = 0;
			for (int i = 1; i < A.Length; i++) {
				key = A[i];
				j = i - 1;
				while (j >= 0 && A[j] < key) {
					A[j + 1] = A[j];
					j--;
				}
				A[j + 1] = key;
			}
			for (int i = 0; i < A.Length; i++)
				Console.Write("{0} ", A[i]);
			Console.WriteLine();
		}			
	}
}