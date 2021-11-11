using System;
using System.Collections.Generic;
using System.Text;

namespace _1Calculator
{
    class DateCalculation
    {
        public static string PerformOneDateCalculation()
        {
            Console.Clear();
            DateTime date = EnterDate();
            int days = DaysToAdd();
            string answer = CalculateDate(date, days);
            string displayDate = date.ToShortDateString();
            string message = (displayDate + " + (" + days + ") days = " + answer);
            Console.WriteLine(message);
            Console.ReadLine();
            return message;

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

        private static string CalculateDate(DateTime date, int days)
        {
            DateTime newDate = date.AddDays(days);
            string answer = newDate.ToShortDateString();
            return answer;
        }
    }
}
