using System;

namespace ArithmeticRow {
	class Program {
		static void Main(string[] args) {
			const double a = 1, n = 4, r = 2;	// r != 1
			Console.WriteLine(ArithmeticRow(a, n, r));
		}
		static double ArithmeticRow(double a, double n, double r) {
			return (a * (1 - Math.Pow(r, n))) / (1 - r);
		}
	}
}