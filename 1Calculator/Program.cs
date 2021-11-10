﻿using System;

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
}
