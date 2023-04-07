namespace Open_Closed;

public class MagicClass
{
    public void CountYourMagic(IMagic? Magic)
    {
        if (Magic != null)
        {
            Console.WriteLine($"Wow, your magic is {Magic.MagicName}");
            return;
        } 
        Console.WriteLine("I understand you...");
    }
}