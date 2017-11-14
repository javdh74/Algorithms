using System;

namespace GeometricRow {
	class Program {
		static void Main(string[] args) {
			const double a = 1.0, r = 0.5;	// -1 < r < 1
			Console.WriteLine(GeometicRow(a, r));
		}
		static double GeometicRow(double a, double r) {
			return a / (1 - r);
		}
	}
}