using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ST10351721
//Ethan Shaun Moodley 
//PROG ICE Task 4

namespace SimpleCalculator
{

    public delegate void CalculationEventHandler(string operation, double result);

    public class Calculator
    {

       
        public event CalculationEventHandler CalculationPerformed;
       
        public double Add(double num1 , double num2)
        {
            double result = num1 + num2;

            OnCalculationPerformed("Addition", result);
            return result;
        }

        public double Subtract(double num1,double num2)
        {
            double result = num1 - num2;

            OnCalculationPerformed("Subtraction", result);
            return result;
        }

        public double Multiply(double num1 ,double num2)
        {
            double result = num1 * num2;

            OnCalculationPerformed("Multiplication" , result);
            return result;
        }

        public double Divide(double num1,double num2)
        {
            if(num1 == 0 || num2 == 0 )
            {
                //Error checking is value will become undefined
                Console.WriteLine("Error: Division by zero.");
                return double.NaN;
            }

            double result = num1 / num2;
            OnCalculationPerformed("Division", result);
            return result;
        }

        protected virtual void OnCalculationPerformed(string operation, double result)
        {
            CalculationPerformed?.Invoke(operation, result);
        }



    }
}
