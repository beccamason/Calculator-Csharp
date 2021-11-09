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

            while (true)
            {
                PerformOneCalculation();
            }
        }
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }
        private static void PerformOneCalculation()
        {
            double firstNumber = EnterNumber();
            double secondNumber = EnterNumber();
            string operatorChoice = Operator();
            double answer = CalculateAnswer(firstNumber, secondNumber, operatorChoice);

            Console.WriteLine("The answer is: " + answer);

        }

        private static double EnterNumber()
        {
            Console.Write("Enter a number: ");
            bool res = true;
            double a;
            string yourNumber = Console.ReadLine();
            res = double.TryParse(yourNumber, out a);
            if (res == true)
            {
                double yourDouble = Convert.ToDouble(yourNumber);
                return yourDouble;
            }
            else
            {
                Console.WriteLine("Sorry, that doesn't look like a number.  Please try again!");
                double yourDouble = Convert.ToDouble(EnterNumber());
                return yourDouble;
            }
        }

        private static string Operator()
        {
            Console.Write("What operator would you like to use? Please choose from + - * and /: ");
            string operatorChoice = Console.ReadLine();
            return operatorChoice;
        }

        private static double CalculateAnswer(double firstNumber, double secondNumber, string operatorChoice)
        {
            double answer;

            if (operatorChoice == "+")
            {
                answer = firstNumber + secondNumber;
                return answer;
            }
            else if (operatorChoice == "-")
            {
                answer = firstNumber - secondNumber;
                return answer;
            }
            else if (operatorChoice == "*")
            {
                answer = firstNumber * secondNumber;
                return answer;
            }
            else if (operatorChoice == "/")
            {
                answer = firstNumber / secondNumber;
                return answer;
            }
            else
            {
                return 0;
            }

        }

    }
}
