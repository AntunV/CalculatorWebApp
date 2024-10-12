using CalculatorWebApp.Models;
using CalculatorWebApp.Service.Implementations;
using CalculatorWebApp.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApp.Controllers
{
    namespace CalculatorWebApp.Controllers
    {
        public class CalculatorController : Controller
        {
            private readonly ICalculatorService calculatorService;

            public CalculatorController(ICalculatorService calculatorService)
            {
                this.calculatorService = calculatorService;
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Calculate(double num1, double num2, string operation)
            {
                double result = 0;
                try
                {
                    switch (operation)
                    {
                        case "Add":
                            result = calculatorService.Add(num1, num2);
                            break;
                        case "Subtract":
                            result = calculatorService.Subtract(num1, num2);
                            break;
                        case "Multiply":
                            result = calculatorService.Multiply(num1, num2);
                            break;
                        case "Divide":
                            result = calculatorService.Divide(num1, num2);
                            break;
                        case "Sqrt":
                            result = calculatorService.Sqrt(num1);
                            break;
                        case "Percentage":
                            result = calculatorService.Percentage(num1, num2);
                            break;
                        case "Sine":
                            result = calculatorService.Sine(num1);
                            break;
                        case "Cosine":
                            result = calculatorService.Cosine(num1);
                            break;
                        case "Tangent":
                            result = calculatorService.Tangent(num1);
                            break;
                        default:
                            ViewBag.ErrorMessage = "Invalid operation!";
                            return View("Index");
                    }

                    ViewBag.Result = result;
                }
                catch (ArgumentException ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                }

                return View("Index");
            }
        }
       
    }
    
}
