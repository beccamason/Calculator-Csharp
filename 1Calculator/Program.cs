using System;

namespace _1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
/*            //Exercist 2
            Console.Write("Hey! What's your name? ");
            string aFriend = Console.ReadLine();
            Console.WriteLine("Welcome to the Calculator " + aFriend);*/
            
            //Exercise 3
/*            Console.Write("Hey! What's the radius of your circle? ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = (radius * radius * (Math.PI));
            Console.WriteLine("Great, the area of your circle is " + area);*/

            Console.Write("Hey! Pick a number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thanks! Now please pick another number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double sum = firstNumber + secondNumber;
            double product = firstNumber * secondNumber;
            Console.WriteLine("Great, the sum of those two number is " + sum + " and the product of your numbers is " + product);

        }
    }
}
