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
            person.Introduce();
            person.Talk(); //Jenifer is talking...
            person.Say("I want to play SCII");
            person.CalculateSum(3.14, 6);
            //3.14 + 6 = 9.14;
            

            Human anotherPerson = new Human();
            anotherPerson.Name = "John";
            anotherPerson.Surname = "Nash";
            anotherPerson.Age = 35;
            anotherPerson.Introduce();
            anotherPerson.Talk(); //John is talking...
            anotherPerson.Say("I am hungry");
        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public void Talk()
        {
            Console.WriteLine(Name + " is talking...");
        }

        public void Say(string message)
        {
            Console.WriteLine(Name + " says: " + message);
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name + ", I am " + Age + " years old.");
        }
    }
}
