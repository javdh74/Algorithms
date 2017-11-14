using System;

namespace LeastCommonMultple {
	class Program {
		static void Main(string[] args) {
			const int a = 252, b = 105;
			Console.WriteLine("Least Common Multiple of {0} and {1} = {2}", a, b, lcm(a, b));
		}
		static int gcd(int a, int b) {
			if (b == 0)
				return a;
			else
				return gcd(b, a % b);
		}
		static int lcm(int a, int b) {
			return a * b / gcd(a, b);
		}
	}
}