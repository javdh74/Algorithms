using System;

namespace MergeSort {
	class Program {
		static void Main(string[] args) {
			string[] strings = new string[] { "0987654321", "zyxwvutrsqponmlkjihgfedcba", "ZYXWVUTRSQPONMLKJIHGFEDCBA" };
			string[] sortedStrings = MergeSort(strings);
			foreach(string sortedString in sortedStrings)
				Console.WriteLine(sortedString);
		}
		static bool CompareStrings(string str1, string str2) {
			int i = 0;
			while (i < str1.Length && i < str2.Length)
				if (str1[i] == str2[i])
					i++;
				else
					return str1[i] < str2[i];
			return str1.Length <= str2.Length;
		}
		static string[] MergeSort(string[] strings) {
			if (strings.Length <= 1)
				return strings;
			int firstPart = strings.Length / 2;
			string[] sorted = new string[strings.Length], strings1 = new string[firstPart], strings2 = new string[strings.Length - firstPart];
			for (int i = 0; i < firstPart; i++)
				strings1[i] = strings[i];
			for (int i = firstPart; i < strings.Length; i++)
				strings2[i - firstPart] = strings[i];
			strings1 = MergeSort(strings1); strings2 = MergeSort(strings2);
			int j = 0, k = 0;
			for (int i = 0; i < sorted.Length; i++)
				if (j == strings1.Length) {
					sorted[i] = strings2[k];
					k++;
				} else if (k == strings2.Length) {
					sorted[i] = strings1[j];
					j++;
				} else if (CompareStrings(strings1[j], strings2[k])) {
					sorted[i] = strings1[j];
					j++;
				} else {
					sorted[i] = strings2[k];
					k++;
				}
			return sorted;
		}
	}
}