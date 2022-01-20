using System;

namespace Exercise_2
{
    class Student : Person
    {
        private double gpa;

        public Student()
        {
        }

        public Student(double gpa)
        {
            this.Gpa = gpa;
        }

        public Student(int age, string name) : base(age, name)
        {
        }

        public Student(int age, string name, double gpa) : base(age, name)
        {
            this.Gpa = gpa;
        }

        public double Gpa { get => gpa; set => gpa = value; }

        public void Input(int age, String name, double gpa)
        {
            base.Age = age;
            base.Name = name;
            this.Gpa = gpa;
        }
        public void DisplayStudent()
            => Console.WriteLine($"This is a student\n Age = {Age}\n Name: {Name}\n GPA = {Gpa}");


    }
}
