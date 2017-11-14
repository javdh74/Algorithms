using System;
using System.Numerics;

namespace Faculty {
	class Program {
		static void Main(string[] args) {
			const int limit = 100;
			Console.WriteLine(Faculty(limit));
		}
		static BigInteger Faculty(int n) {
			if (n < 0)
				return 0;
			BigInteger product = 1;
			for (int j = 1; j <= n; j++)
				product *= j;
			return product;
		}
	}
}
