using System;
using Praktika;
class Starter {
    static void Main(string[] args) {
        Console.WriteLine("lab 1-5 (0 - exit):");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n != 0) {
            switch (n) {
                case 1:
                    new Discriminant().Main();
                    break;
                case 2:
                    new Tabulation().Main();
                    break;
                case 3:
                    new Integral().Main();
                    break;
                case 4:
                    new Det().Main();
                    break;
                case 5:
                    new Gauss().Main();
                    break;
                default:
                    Console.WriteLine("There is not such");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("lab 1-5 (0 - exit):");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
