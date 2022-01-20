using System;

namespace Exercise_2
{
    class Person
    {
        private int age;
        private String name;

        public Person()
        {
        }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public void DisplayPerson()
            => Console.WriteLine($"This is a person\n Age = {Age}\n Name: {Name}");

        public void Input(int age, String name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
