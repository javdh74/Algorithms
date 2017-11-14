using System;
using System.Collections;
using System.Collections.Generic;

namespace SieveOfEratosthenes {
	class Program {
		static void Main(string[] args) {
			const int limit = 1000;
			int[] primes = ESieve(limit);
			for (int i = 0; i < primes.Length; i++)
				Console.Write("{0}\t", primes[i]);
			Console.WriteLine();
		}
		static int[] ESieve(int upperLimit) {
			int sieveBound = (int)(upperLimit - 1) / 2, upperSqrt = ((int)Math.Sqrt(upperLimit - 1) / 2);
			BitArray primeBits = new BitArray(sieveBound + 1, true);
			for (int i = 1; i <= upperSqrt; i++)
				if (primeBits.Get(i))
					for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
						primeBits.Set(j, false);
			List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
			numbers.Add(2);
			for (int i = 1; i <= sieveBound; i++)
				if (primeBits.Get(i))
					numbers.Add(2 * i + 1);
			return numbers.ToArray();
		}
	}
}