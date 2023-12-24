using System;
namespace Praktika {
    class Discriminant {
        public void Main() {
            Console.WriteLine("Input the value of a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the value of b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the value of c:");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0 && b == 0 && c == 0) {
                Console.WriteLine("X = inf");
                return;
            }
            if (a == 0) {
                if (b == 0) {
                    Console.WriteLine("There is not solution");
                } else {
                    double x = -c / b;
                    Console.WriteLine("x = " + x);
                }
            } else {
                if (b == 0) {
                    double x1, x2;
                    x1 = Math.Sqrt(-c / a);
                    x2 = -Math.Sqrt(-c / a);
                    Console.WriteLine("x = " + x1 + " and " + x2);
                } else {
                    if (c == 0) {
                        double x1, x2;
                        x1 = 0;
                        x2 = -b / a;
                        Console.WriteLine("x = " + x1 + " and " + x2);
                    } else {
                        double D = CalculateDiscriminant(a, b, c);
                        if (D > 0) {
                            double x1, x2;
                            x1 = (-b + Math.Sqrt(D)) / (2 * a);
                            x2 = (-b - Math.Sqrt(D)) / (2 * a);
                            Console.WriteLine("x = " + x1 + " and " + x2);
                        } else {
                            if (D == 0) {
                                double x = (-b) / (2 * a);
                                Console.WriteLine("x = " + x);
                            } else {
                                Console.WriteLine("X is not exists");
                            }
                        }
                    }
                }
            }
            return;
        }

        static double CalculateDiscriminant(double a, double b, double c) {
            return (b * b) - (4 * a * c);
        }
    }
}