using System;

namespace _1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
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

            PrintWelcomeMessage();
            bool keepGoing = true;

            while (keepGoing)
            {
                PerformOneCalculation();
                keepGoing = GoAgain();
            }
        }
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }
        private static void PerformOneCalculation()
        {
            string operatorChoice = Operator();
            double firstNumber = Convert.ToDouble(EnterNumber());
            double secondNumber = Convert.ToDouble(EnterNumber());
            if (operatorChoice == "+")
            {
                Console.WriteLine("Answer: " + (firstNumber + secondNumber));
            }
            else if (operatorChoice == "-")
            {
                Console.WriteLine("Answer: " + (firstNumber - secondNumber));
            }
            else if (operatorChoice == "*")
            {
                Console.WriteLine("Answer: " + (firstNumber * secondNumber));
            }
            else if (operatorChoice == "/")
            {
                Console.WriteLine("Answer: " + (firstNumber / secondNumber));
            }                
        }

        private static double EnterNumber()
        {
            Console.Write("Enter a number: ");
            double yourNumber = Convert.ToDouble(Console.ReadLine());
            return yourNumber;
        }

        private static string Operator()
        {
            Console.Write("What operator would you like to use? Please choose from + - * and /: ");
            string operatorChoice = Console.ReadLine();
            return operatorChoice;
        }

        private static bool GoAgain()
        {
            Console.WriteLine("Would you like to do another calculation? Y/N");
            string status = Console.ReadLine();
            if (status == "N")
            {
                return false;
            }
            else
            {
                return true;
            }

        }



    }
}
