
namespace Exercise_4
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value; }

        public double ToDecimal() => (double)Numerator / (double)Denominator;
        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }
    }
}
