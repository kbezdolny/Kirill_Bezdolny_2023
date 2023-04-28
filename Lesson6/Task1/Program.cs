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
        

        while (true)
        {
            Console.Write("First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Action: ");
            var action = Console.ReadLine();
            
            Console.Write("Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculator.Calculate(num1, num2, action);
        }
    }
}