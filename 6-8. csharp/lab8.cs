using System;
namespace Praktika {
    class lab8 {
        public void Main() {
            Console.WriteLine("Input count of numbers (>0):");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; ++i) {
                int temp = Convert.ToInt32(Console.ReadLine());
                numbers[i] = temp;
            }

            int result = 1;
            for (int i = 0; i < numbers.Length; ++i) {
                if (numbers[i] < 0 && numbers[i] % 3 == 0 && numbers[i] % 7 == 0) {
                    result *= numbers[i];
                }
            }
            Console.WriteLine(result);
        }

        public void Main2() {
            Console.WriteLine("Input num:");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 1;

            string str = n.ToString().Replace("-", "");
            Console.WriteLine(str);

            for (int i = 0; i < str.Length; ++i) {
                int m = Convert.ToInt32(str[i]);
                if (m % 2 == 1) {
                    res *= (m - 48);
                }
            }
            Console.WriteLine(res);
        }
    }
}
