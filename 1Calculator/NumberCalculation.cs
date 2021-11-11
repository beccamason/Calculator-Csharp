using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _1Calculator
{
    class NumberCalculation
    {
        public static string PerformOneNumberCalculation()
        {
            Console.Clear();
            double[] numberArray = GetNumberArray();
            string operatorChoice = Operator();
            double answer = CalculateAnswer(numberArray, operatorChoice);

            string message = "the answer is " + answer;
            Console.WriteLine(message);
            Console.ReadLine();
            return message;
        }

        private static double[] GetNumberArray()
        {
            Console.WriteLine("How many numbers are we working with here? ");
            int totalValues = Convert.ToInt32(Console.ReadLine());
            double[] numberArray = new double[totalValues];
            for (int i = 0; i < totalValues; i++)
            {
                double newNumber = EnterNumber();
                numberArray[i] = newNumber;
            }
            return numberArray;
        }
        private static double EnterNumber()
        {
                Console.Write("Enter number: ");
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


        private static double CalculateAnswer(double[] numberArray, string operatorChoice)
        {
            double answer = numberArray[0];
            if (operatorChoice == "+")
            {
                answer = numberArray.Sum();
            }
            else if (operatorChoice == "-")
            {
                answer = numberArray.Aggregate((a, b) => a - b);
            }
            else if (operatorChoice == "*")
            {
                answer = numberArray.Aggregate((a, b) => a * b);
            }
            else if (operatorChoice == "/")
            {
                answer = numberArray.Aggregate((a, b) => a / b);
            }
            return answer;
        }
    }
}
