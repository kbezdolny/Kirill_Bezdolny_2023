namespace Task1;

public static class Calculator
{
    public static void Calculate(double num1, double num2, string action)
    {
        Operations operation = new Operations();
        switch (action)
        {
            case "+":
                operation.Calc(num1, num2, operation.Add);
                break;
            case "-":
                operation.Calc(num1, num2, operation.Subtract);
                break;
            case "/":
                operation.Calc(num1, num2, operation.Devide);
                break;
            case "*":
                operation.Calc(num1, num2, operation.Multiply);
                break;
            case "^":
                operation.Calc(num1, num2, operation.Power);
                break;
            default:
                Console.WriteLine("Operation does not exist!\n");
                break;
        }
    }
}