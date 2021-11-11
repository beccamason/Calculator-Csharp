using System;
using System.IO;
using System.Threading.Tasks;

namespace _1Calculator
{
    class Program
    {
        private const string NumberCalculator = "1";
        private const string DateCalculator = "2";
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                string calculationMode = AskForCalculationMode();

                if (calculationMode == NumberCalculator)
                {
                    Logging numberLog = new Logging();
                    numberLog.LogNumberAnswer();                    
                }
                else
                {
                    Logging dateLog = new Logging(); 
                    dateLog.LogDateAnswer();
                }
            }
        }

        private static string AskForCalculationMode()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do today?");
            Console.WriteLine("1) Number Calculation");
            Console.WriteLine("2) Date Calculation");
            string mode = Console.ReadLine();
            return mode;
        }
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator! Ready to get started?");
            Console.ReadLine();
        }

    }
}
