using System;
using Praktika;
class Starter {
    public void Main(string[] args) {
        Console.WriteLine("lab 6-8 (0 - exit):");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n != 0) {
            switch (n) {
                case 6:
                    new lab6().Main();
                    break;
                case 71:
                    new lab7().Main();
                    break;
                case 72:
                    new lab7().Main2();
                    break;
                case 81:
                    new lab8().Main();
                    break;
                case 82:
                    new lab8().Main2();
                    break;
                default:
                    Console.WriteLine("There is not such");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("lab 6-8 (0 - exit):");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
