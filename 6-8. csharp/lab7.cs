using System;
namespace Praktika {
    class lab7 {
        public void Main() {
            Console.WriteLine("Input a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input b:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b) {
                Console.WriteLine("Числа равны");
            } else {
                int max = Math.Max(a, b);
                int min = Math.Min(a, b);
                Console.WriteLine("Число {0} меньше числа {1} на {2}", min, max, max - min);
            }
        }

        public void Main2() {
            Console.WriteLine("Input a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input c:");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a < b ? (b > c ? b : c) : (a > c ? a : c);
            int min = a < b ? (a < c ? a : c) : (b < c ? b : c);

            if (max == min) {
                Console.WriteLine("Максимальное и минимальное равны");
            } else {
                Console.WriteLine("Число {0} меньше числа {1} на {2}", min, max, max - min);
            }
        }
    }
}
