using System;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings from Datorium!");
            Console.WriteLine("This is the entry point");

            //creating first person as a human
            Human person = new Human();
            person.Name = "Anna";
            person.Surname = "Jackson";
            person.Age = (decimal)25.3;
            person.Height = (decimal)176;

            person.Introduce();
            person.Talk();
            person.Say("Now I will use my rain to calculate.");
            person.CalculateSum(3.14, 5);
            person.Calculate(6, "/", 11);

            //creating another person as a human
            Human anotherPerson = new Human();
            anotherPerson.Name = "Nick";
            anotherPerson.Surname = "Bright";

            anotherPerson.Introduce();
            anotherPerson.Talk();
            anotherPerson.Say("Welcome to my place!");
        }
    }

    //C, C++, C#

    class Human
    {
        public string Name;
        public string Surname;
        public decimal Age;
        public decimal Height;

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
            Console.WriteLine("Hi, my name is " + this.Name);
        }

        public void CalculateSum(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine(firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + sum.ToString());
        }

        public void Calculate(double firstNumber, string operation, double secondNumber)
        {
            double answer;

            if(operation == "+")
            {
                answer = firstNumber + secondNumber;
            }
            else if(operation == "-")
            {
                answer = firstNumber - secondNumber;
            }
            else if(operation == "*")
            {
                answer = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                answer = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Unknown operation.");
                return;
            }
            Console.WriteLine(firstNumber.ToString() + operation + secondNumber.ToString() + "=" + answer.ToString());
        }

    }
}
