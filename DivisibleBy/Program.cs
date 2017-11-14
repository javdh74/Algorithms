using System;
using System.Numerics;

namespace DivisibleBy {
	class Program {
		static void Main(string[] args) {
			Console.Write("Enter numerator: ");
			BigInteger numerator = BigInteger.Parse(Console.ReadLine());
			Console.Write("Enter denominator: ");
			BigInteger denominator = BigInteger.Parse(Console.ReadLine());
			if (DivisibleBy(numerator, denominator))
				Console.WriteLine("{0} is divisible by {1}", numerator, denominator);
			else
				Console.WriteLine("{0} is not divisible by {1}", numerator, denominator);
		}
		static bool DivisibleBy(BigInteger n, BigInteger d) {
			if (n % d == 0)
				return true;
			else
				return false;
		}
	}
}
