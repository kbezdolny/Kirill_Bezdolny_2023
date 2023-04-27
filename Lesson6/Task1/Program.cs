using Task1;

public class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n┌───────────────────────────┐" +
                          "\n│ Operations: +, -, /, *, ^ │" +
                          "\n└───────────────────────────┘\n");
        Console.ForegroundColor = ConsoleColor.White;
        
        Operations operation = new Operations();

        while (true)
        {
            
            Console.Write("First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Action: ");
            var action = Console.ReadLine();
            
            Console.Write("Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
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
}