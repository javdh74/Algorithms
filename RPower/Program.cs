using System;

namespace RPower {
	class Program {
		static void Main(string[] args) {
			const double r = 9.99;
			const int exponent = 1001;
			Console.WriteLine((decimal)Math.Pow(r, exponent));
		}
	}
}