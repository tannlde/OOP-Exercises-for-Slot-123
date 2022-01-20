using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class FractionsManager
    {
        private Fraction f1;
        private Fraction f2;

        internal Fraction F1 { get => f1; set => f1 = value; }
        internal Fraction F2 { get => f2; set => f2 = value; }

        public void Input()
        {
            F1 = new(InputInteger("Numerator 1"), InputInteger("Denominator 1"));
            F2 = new(InputInteger("Numerator 2"), InputInteger("Denominator 2"));
            Console.WriteLine($"The Fraction 1 after normalize = {Normalize(F1)}");
            Console.WriteLine($"The Fraction 2 after normalize = {Normalize(F2)}");

        }

        public Fraction Add() => Calculator('+');

        public Fraction Subtract() => Calculator('-');

        public Fraction Multiply() => Calculator('*');

        public Fraction Divide() => Calculator('/');

        public void Display()
        {
            Console.WriteLine($"({F1}) {F1.Numerator} is the numerator, {F1.Denominator} is the denominator");
            Console.WriteLine($"({F2}) {F2.Numerator} is the numerator, {F2.Denominator} is the denominator");

        }

        public void DisplayAsDecimal()
        {
            Console.WriteLine($"F1= {F1.ToDecimal()}");
            Console.WriteLine($"F2= {F2.ToDecimal()}");

        }
        private static int InputInteger(string var = "a integer")
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
        private int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
       
        private Fraction Normalize(Fraction f)
        {
            int gcd = GCD(f.Numerator, f.Denominator);
            return new(f.Numerator / gcd, f.Denominator / gcd);
        }

        private static Fraction Multiply(Fraction f1, Fraction f2) 
            => new(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);

        private Fraction Calculator(char o)
        {
            int generalDeno = F1.Denominator * F2.Denominator;
            switch (o)
            {
                case '+': return Normalize(new(F1.Numerator * F2.Denominator + F1.Denominator * F2.Numerator, generalDeno));
                case '-': return Normalize(new(F1.Numerator * F2.Denominator - F1.Denominator * F2.Numerator, generalDeno));
                case '*': return Normalize(Multiply(F1, F2));
                case '/': return Normalize(Multiply(F1, new(F2.Denominator, F2.Numerator)));
                default:
                    break;
            }
            return null;
        }

    }
}
