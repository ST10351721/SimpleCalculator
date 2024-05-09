using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator CalcObj = new Calculator();

            CalcObj.CalculationPerformed += (operation, result) =>
            {
                Console.WriteLine($"Operation:{operation}, Result: {result}");
            };

            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation (+ , - , * , /):");
            char UserOption = Convert.ToChar(Console.ReadLine());

            double UserOutput;

            //Switch , case statement gets char value and therefore assignes appropriate calculated value in result
            switch (UserOption)
            {
                case '+':
                    UserOutput = CalcObj.Add(num1 , num2);
                    break;
                case '-':
                    UserOutput = CalcObj.Subtract(num1, num2);
                    break;
                case '*':
                    UserOutput = CalcObj.Multiply(num1, num2);
                    break;
                case '/':
                    UserOutput = CalcObj.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    UserOutput = double.NaN;
                    break;
            }

            Console.WriteLine($"Result: {UserOutput}");





        }
    }
}
