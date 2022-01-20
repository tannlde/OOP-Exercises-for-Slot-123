using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionsManager fractionsManager = new FractionsManager();
            fractionsManager.Input();
            Console.WriteLine($"Add = {fractionsManager.Add()}");
            Console.WriteLine($"Sub = {fractionsManager.Subtract()}");
            Console.WriteLine($"Mul = {fractionsManager.Multiply()}");
            Console.WriteLine($"Div = {fractionsManager.Divide()}");
            fractionsManager.Display();
            fractionsManager.DisplayAsDecimal();
        }
    }
}
