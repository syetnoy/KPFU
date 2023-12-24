using System;
namespace Praktika {
    class Gauss {
        public void Main() {
            Console.WriteLine("Input matrix size (>0):");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0) {
                n = Convert.ToInt32(Console.ReadLine());
            }
            int m = n + 1;
            Console.WriteLine("Matrix[{0}, {1}]", n, m);

            float[,] Matrix = new float[n, m];
            float[] Result = new float[n];

            int i = 0, j = 0;
            while (i < n) {
                j = 0;
                while (j < m) {
                    Console.WriteLine("Input Matrix[{0}][{1}] element:", i, j);
                    
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    ++j;
                }
                ++i;
            }

            i = 0;
            while (i < n) {
                j = i + 1;
                while (j < n) {
                    if (Matrix[i, i] != 0) {
                        float temp = Matrix[j, i] / Matrix[i, i];
                        Console.WriteLine(temp);
                        int k = 0;
                        while (k < m) {
                            Matrix[j, k] -= temp * Matrix[i, k];
                            ++k;
                        }
                    }
                    ++j;
                }
                ++i;
            }

            for (i = n - 1; i >= 0; i--) {
                Result[i] = Matrix[i, n] / Matrix[i, i];
                for (int k = i - 1; k >= 0; k--) {
                    Matrix[k, n] -= Matrix[k, i] * Result[i];
                }
            }

            for (i = 0; i < n; ++i) {
                Console.WriteLine(Result[i]);
            }
        }
    }
}