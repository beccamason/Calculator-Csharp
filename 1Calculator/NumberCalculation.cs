using System;
using System.Collections.Generic;
using System.Text;

namespace _1Calculator
{
    class NumberCalculation
    {
        public static void PerformOneNumberCalculation()
        {
            Console.Clear();
            double firstNumber = EnterNumber();
            double secondNumber = EnterNumber();
            string operatorChoice = Operator();
            double answer = CalculateAnswer(firstNumber, secondNumber, operatorChoice);

            Console.WriteLine("The answer is: " + answer + ".  Press any key to go again...");
            Console.ReadLine();
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
