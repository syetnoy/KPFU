using System;
namespace Praktika {
    class Integral {
        public void Main() {
            double a, b, n;
            do {
                Console.WriteLine("Input a:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input b:");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input n:");
                n = Convert.ToDouble(Console.ReadLine());

            } while (!(a < b && n > 0));
            
            int i = 0;
            double S = 0;
            double h = (b - a) / n;

            while (i < n) {
                double x = a + i * h;
                double y = h * f(x);
                S += y;
                i += 1;
            }
            Console.WriteLine(S.ToString("0.00"));
        }

 
        static double f(double x) {
            if (Math.Sin(x) >= 0) {
                return (Math.Cos(x)) / (4 + Math.Sqrt(Math.Sin(x)));
            }
            return 0;
        }
    }
}