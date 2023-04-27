namespace Task1;

public class Operations
{
    private delegate void Handler(string message);
    private event Handler? Event; 

    public double Add(double num1, double num2) => num1 + num2;
    public double Subtract(double num1, double num2) => num1 - num2;
    public double Devide(double num1, double num2) => num2 != 0 ? num1 / num2 : 0;
    public double Multiply(double num1, double num2) => num1 * num2;
    public double Power(double num1, double num2) => Math.Pow(num1, num2);
    
    public delegate double Action(double num1, double num2);
    public void Calc(double num1, double num2, Action action)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Event = message => Console.WriteLine(message);
        Event.Invoke($"Calculate result: {action(num1, num2)}\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}