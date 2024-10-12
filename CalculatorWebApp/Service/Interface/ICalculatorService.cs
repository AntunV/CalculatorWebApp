namespace CalculatorWebApp.Service.Interface
{
    public interface ICalculatorService
    {
        double Add(double num1, double num2);
        double Cosine(double num1);
        double Divide(double num1, double num2);
        double Multiply(double num1, double num2);
        double Percentage(double num1, double percent);
        double Sine(double num1);
        double Sqrt(double num1);
        double Subtract(double num1, double num2);
        double Tangent(double num1);
    }
}