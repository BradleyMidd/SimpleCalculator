namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double num1, double num2)
        {
            double result;
            switch (operation.ToLower()) 
            {
                case "+":
                case "add":
                    result = num1 + num2;
                    break;
                case "-":
                case "subtract":
                    result = num1 - num2;
                    break;
                case "*":
                case "multiply":
                    result = num1 * num2;
                    break;
                case "/":
                case "divide":
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not reconized");
                    break;
            }

            return result;
        }
    }
}