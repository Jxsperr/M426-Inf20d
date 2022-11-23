using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        } 

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.log("Kann nicht durch 0 dividiert werden!")
            }

            return a / b;
        }
    }
}
