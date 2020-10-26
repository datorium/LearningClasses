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
            person.Introduce();
            person.Talk();
            person.Say("Good evening");
            person.CalculateSum(6, 11);
            person.Calculate(25, "/", 4);
            

            anotherPerson.Name = "John";
            anotherPerson.Surname = "Nash";
            anotherPerson.Age = 18;
            anotherPerson.Introduce();
            anotherPerson.Talk();
            anotherPerson.Say("Greetings from me");
            person.CalculateSum(45, 99);
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

        public void Say(string message)
        {
            Console.WriteLine(message);
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + this.Name + ", I am " + this.Age.ToString() + " years old.");
        }

        public void CalculateSum(int a, int b)
        {
            int answer = a + b;
            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + answer.ToString());
        }

        public void Calculate(double a, string operation, double b)
        {
            double answer;
            if(operation == "+")
            {
                answer = a + b;
            }
            else if(operation == "-")
            {
                answer = a - b;
            }
            else if (operation == "*")
            {
                answer = a * b;
            }
            else if (operation == "/")
            {
                answer = a / b;
            }
            else
            {
                Console.WriteLine("Operation not defined!");
                return;
            }
            Console.WriteLine(a.ToString() + operation + b.ToString() + " = " + answer.ToString());
        }
    }
}
