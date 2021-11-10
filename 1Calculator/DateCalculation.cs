using System;
using System.Collections.Generic;
using System.Text;

namespace _1Calculator
{
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
