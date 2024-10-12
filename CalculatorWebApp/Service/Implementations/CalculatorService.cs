using CalculatorWebApp.Service.Interface;

namespace CalculatorWebApp.Service.Implementations
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Division by zero is not acceptable");
            }
            return num1 / num2;
        }
        public double Sqrt(double num1)
        {
            if (num1 < 0)
            {
                throw new ArgumentException("Square root of a negative number is not a real number.");
            }
            return Math.Sqrt(num1);
        }
        public double Percentage(double num1, double percent)
        {
            return (num1 * percent) / 100;
        }
        public double Sine(double num1)
        {
            return Math.Sin(num1);
        }

        public double Cosine(double num1)
        {
            return Math.Cos(num1);
        }

        public double Tangent(double num1)
        {
            return Math.Tan(num1);
        }
    }
}
