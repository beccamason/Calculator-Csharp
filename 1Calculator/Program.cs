using System;

namespace _1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercist 2
            /*          Console.Write("Hey! What's your name? ");
                      string aFriend = Console.ReadLine();
                      Console.WriteLine("Welcome to the Calculator {0}", aFriend);
          */
            //Exercise 3
            /*            Console.Write("Hey! What's the radius of your circle? ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        double area = (radius * radius * (Math.PI));
                        Console.WriteLine("Great, the area of your circle is " + area);*/

            //Exercise 4.1
            /*            Console.Write("Hey! What's your first name? ");
                        string firstName = Console.ReadLine();
                        Console.Write("Thanks {0}, what's your surname? ", firstName);
                        string secondName = Console.ReadLine();
                        Console.WriteLine("Welcome to the Calculator {0} {1}", firstName, secondName);*/

            //Calculator Challenge

            Console.Write("What operator would you like to use? Please choose from + - * and /: ");
            string operatorChoice = Console.ReadLine();
            Console.Write("Thanks. Pick your first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thanks! Now please pick another number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            string message = "";

            if (operatorChoice == "+")
                message = ("The answer is " + (firstNumber + secondNumber));
            else if (operatorChoice == "-")
                message = ("The answer is " + (firstNumber - secondNumber));
            else if (operatorChoice == "*")
                message = ("The answer is " + (firstNumber * secondNumber));
            else if (operatorChoice == "/")
                message = ("The answer is " + (firstNumber / secondNumber));
            else
                message = "Sorry, that wasn't a recognised operator!";

            Console.WriteLine(message);


        }
    }
}
