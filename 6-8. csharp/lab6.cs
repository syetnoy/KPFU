using System;
namespace Praktika {
    class lab6 {
        public void Main() {
            Console.WriteLine("Input value a (>0):");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input value b (>0):");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            int s = a * b;

            Console.WriteLine("Гипотенуза = {0}", c);
            Console.WriteLine("Площадь = {0}", s);
        }
    }
}
