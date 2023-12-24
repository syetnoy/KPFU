using System;
namespace Praktika {
	class Tabulation {
		public void Main() {
			double a, b, h;
			do {
				Console.WriteLine("Input a:");
				a = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

				Console.WriteLine("Input b:");
				b = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

				string temp;
				Console.WriteLine("Input h:");
				temp = Console.ReadLine();
                double.TryParse(temp, out h);
				h = Math.Round(h, 3);

			} while (!((a >= b && h < 0) || (a <= b && h > 0)));
			
			double x = a;

			for (int z = 0; z < 49; ++z) Console.Write("-");
			Console.WriteLine();

			while ((x <= b && h > 0) || (x >= b && h < 0)) {
                if (Math.Round(x, 3) == 0) {
                    x += h;
                    continue;
                }

				double y = f(Math.Round(x, 3));
				Console.WriteLine("|\tx = {0}\t|\ty = {1}\t|", x.ToString("0.000"), y.ToString("0.000"));
				x += h;
				x = Math.Round(x, 3);
			}

			for (int z = 0; z < 49; ++z) Console.Write("-");
			Console.WriteLine();
		}

		static double f(double x) {
			return 4 - x - 4 / (x * x);
		}
	}
}