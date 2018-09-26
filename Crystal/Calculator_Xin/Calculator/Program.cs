using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;

            Console.Write("Please input the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input operator: ");
            string operationalCharacter = Console.ReadLine();

            Console.Write("The output is: ");
            switch (operationalCharacter)
            {
                case "+":
                    Console.WriteLine(Calculator.Add(firstNumber, secondNumber));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Subtract(firstNumber, secondNumber));
                    break;
                case "/":
                    Console.WriteLine(Calculator.Divide(firstNumber, secondNumber));
                    break;
                case "*":
                    Console.WriteLine(Calculator.Multiply(firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("input error");
                    break;
            }

            ;
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public static double Add(double num1, double num2)
        {
            double result = 0;
            result = num1 + num2;
            return result;
        }

        public static double Subtract(double num1, double num2)
        {
            double result = 0;
            result = num1 - num2;
            return result;
        }

        public static double Divide(double num1, double num2)
        {
            double result = 0;
            result = num1 / num2;
            return result;
        }

        public static double Multiply(double num1, double num2)
        {
            double result = 0;
            result = num1 * num2;
            return result;
        }
    }

}
