using System;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            Human anotherPerson = new Human();
      
            person.Name = "Jenifer";
            person.Surname = "Lopez";
            person.Age = 32;            
            Console.WriteLine(person.Name + " " + person.Surname + " " + person.Age.ToString());

            anotherPerson.Name = "John";
            anotherPerson.Surname = "Nash";
            anotherPerson.Age = 18;
            Console.WriteLine(anotherPerson.Name + " " + anotherPerson.Surname + " " + anotherPerson.Age.ToString());
        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public int Age;
    }
}
