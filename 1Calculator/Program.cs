using System;

namespace _1Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                int calculationMode = AskForCalculationMode();

                if (calculationMode == NumberCalculator)
                {
                    NumberCalculation.PerformOneNumberCalculation();
                }
                else
                {
                    DateCalculation.PerformOneDateCalculation();
                }
            }
        }
        private static int AskForCalculationMode()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do today?");
            Console.WriteLine("1) Number Calculation");
            Console.WriteLine("2) Date Calculation");
            int mode = Convert.ToInt32(Console.ReadLine());
            return mode;
        }
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator! Ready to get started?");
            Console.ReadLine();
        }

    }

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

    class DateCalculation
    { 
        public static void PerformOneDateCalculation()
        {
            Console.Clear();
            DateTime date = EnterDate();
            int days = DaysToAdd();
            DateTime answer = CalculateDate(date, days);
            Console.WriteLine("Your new date is: " + answer);
            Console.ReadLine();

        }
        private static DateTime EnterDate()
        {
            Console.Write("Please Enter a Date: ");
            DateTime userDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                DateTime yourDate = Convert.ToDateTime(userDateTime);
                return yourDate;
            }
            else
            {
                Console.WriteLine("Sorry, that doesn't look like a valid date format.  Please try again!");
                DateTime yourDate = Convert.ToDateTime(EnterDate());
                return yourDate;
            }
        }

        private static int DaysToAdd()
        {
            Console.WriteLine("Please enter the number of days to add");
            int days = Convert.ToInt32(Console.ReadLine());
            return days;
        }

        private static DateTime CalculateDate(DateTime date, int days)
        {
            DateTime newDate = date.AddDays(days);
            return newDate;
        }


    }
}
