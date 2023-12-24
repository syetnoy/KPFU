using System;
namespace Praktika {
    class Det {
        public void Main() {
            Console.WriteLine("Input matrix size (>0):");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0) {
                Console.WriteLine("Input matrix size (>0):");
                n = Convert.ToInt32(Console.ReadLine());
            }

            float[,] Matrix = new float[n, n];
            float det = 1;

            int i = 0;
            while (i < n) {
                int j = 0;
                while (j < n) {
                    Console.WriteLine("Input Matrix[{0}][{1}] element:", i, j);
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    ++j;
                }
                ++i;
            }

            i = 0;
            while (i < n) {
                int j = i + 1;
                while (j < n) {
                    if (Matrix[i, i] != 0) {
                        float temp = Matrix[j, i] / Matrix[i, i];
                        int k = i;
                        while (k < n) {
                            Matrix[j, k] -= temp * Matrix[i, k];
                            ++k;
                        }
                    }
                    ++j;
                }
                ++i;
            }

            i = 0;
            while (i != n) {
                det *= Matrix[i, i];
                ++i;
            }
            Console.WriteLine("Det: {0}", det);
        }
    }
}