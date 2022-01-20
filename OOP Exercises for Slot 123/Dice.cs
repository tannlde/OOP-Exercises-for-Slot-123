using System;

namespace OOP_Exercises_for_Slot_123
{
    class Dice
    {
        private Random rd = new Random();
        private int slides;

        public Dice()
        {
        }

        public Dice(int slides)
        {
            this.Slides = slides;
        }

        public int Slides { get => slides; set => slides = value; }

        public int Roll() => rd.Next(1, Slides + 1);

    }
}
