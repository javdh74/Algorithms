using System;

namespace AnPower {
	class Program {
		static void Main(string[] args) {
			const double exponent = 1000.1;
			const int an = 100;
			Console.WriteLine((decimal)Math.Pow(an, exponent));
		}
	}
}
