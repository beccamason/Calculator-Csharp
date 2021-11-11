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
            List<double> numberArray = GetNumberArray();
            string operatorChoice = Operator();
            double? answer = CalculateAnswer(numberArray, operatorChoice);

            string message = "the answer is " + answer;
            Console.WriteLine(message);
            Console.ReadLine();
            return message;
        }

        private static List<double> GetNumberArray()
        {
            List<double> numbers = new List<double>();

            while(true)
            {
                double? number = EnterNumber();
                if (number.HasValue)
                {
                    numbers.Add(number.Value);
                }
                else
                {
                    break;
                }
            }
        
            return numbers;
        }

        private static double? EnterNumber()
        {
            while (true)
            {
                Console.Write("Enter number: ");
                bool res = true;
                double a;
                string yourNumber = Console.ReadLine();
                res = double.TryParse(yourNumber, out a);

                if (yourNumber != "")
                {
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
                else
                {
                    return null;
                }
            }
        }

        private static string Operator()
        {
            Console.Write("What operator would you like to use? Please choose from + - * and /: ");
            string operatorChoice = Console.ReadLine();
            return operatorChoice;
        }
        private static double? CalculateAnswer(List<double> numberArray, string operatorChoice)
        {
            double? answer;

            switch (operatorChoice)
            {
                case "+":
                    answer = numberArray.Sum();
                    break;
                case "-":
                    answer = numberArray.Aggregate((a, b) => a - b);
                    break;
                case "*":
                    answer = numberArray.Aggregate((a, b) => a * b);
                    break;
                case "/":
                    answer = numberArray.Aggregate((a, b) => a / b);
                    break;

                default:
                    answer = null;
                    break;
            }
            return answer;
        }
    }
}
