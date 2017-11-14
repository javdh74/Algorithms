using System;

namespace GreatestCommonDivisor {
	class Program {
		static void Main(string[] args) {
			const int a = 252, b = 105;
			Console.WriteLine("Greatest Common Divisor of {0} and {1} = {2}", a, b, gcdi(a, b));
			Console.WriteLine("Greatest Common Divisor of {0} and {1} = {2}", a, b, gcdr(a, b));
		}
		static int gcdi(int a, int b) {
			while (a != b)
				if (a > b)
					a -= b;
				else
					b -= a;
			return a;
		}
		static int gcdr(int a, int b) {
			if (b == 0)
				return a;
			else
				return gcdr(b, a % b);
		}
	}
}