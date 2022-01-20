using System;

namespace OOP_Exercises_for_Slot_123
{
    class Program
    {
        // Input a integer from keyboard
        static int InputInteger(string var = "a integer")
        {
            Console.Write($"Enter {var}: ");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine($"Must be a integer!");
                Console.Write($"Enter {var}: ");
            }
            return x;
        }
        static void Main(string[] args)
        {
            Dice dice = new(6);
            int x = InputInteger("a guessing number");
            int result = dice.Roll();

            if (x == result)
            {
                Console.WriteLine("Win");
                return;
            }
            Console.WriteLine($"Lose - Result = {result}");

        }
    }
}
