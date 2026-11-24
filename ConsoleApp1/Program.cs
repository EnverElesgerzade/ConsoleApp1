using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(10, 5, '+'));
            Console.WriteLine(Calculate(10, 5, '-'));
            Console.WriteLine(Calculate(10, 5, '*'));
            Console.WriteLine(Calculate(10, 0, '/'));
        }

        static double Calculate(double number1, double number2, char operrator)
        {
            if (operrator == '+')
            {
                return number1 + number2;
            }
            else if (operrator == '-')
            {
                return number1 - number2;
            }
            else if (operrator == '*')
            {
                return number1 * number2;
            }
            else if (operrator == '/')
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Sifira bolmek olmaz!");
                    return 0;
                }
                else
                {
                    return number1 / number2;
                }
            }
            else
            {
                Console.WriteLine("Yanlis operator!");
                return 0;
            }
        }
    }
}