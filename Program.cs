using System;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            person.Name = "Jenifer";
            person.Surname = "Lopez";
            person.Age = 16;   
            Console.WriteLine("Name: " + person.Name + ", Surname: " + person.Surname + ", Age: " + person.Age);
            person.Talk(); //Jenifer is talking...

            Human anotherPerson = new Human();
            anotherPerson.Name = "John";
            anotherPerson.Surname = "Nash";
            anotherPerson.Age = 35;
            Console.WriteLine("Name: " + anotherPerson.Name + ", Surname: " + anotherPerson.Surname + ", Age: " + anotherPerson.Age);
            anotherPerson.Talk(); //John is talking...
        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public void Talk()
        {
            Console.WriteLine("I am talking...");
        }
    }
}
