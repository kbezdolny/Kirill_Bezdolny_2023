namespace Task1.Classes.Details;

public class Cpu : Detail
{
    public string Socket { get; set; }
    public string Cores { get; set; }
    public string Frequency { get; set; }
    public Cpu(decimal price, string supplier, string country,
        string name, string socket, string cores, string frequency)
        : base(price, supplier, country, name)
    {
        Socket = socket;
        Cores = cores;
        Frequency = frequency;
    }

    public string GetInfo()
    {
        return $"{Name} | {Socket} | {Cores} | {Frequency} | Price: {Price}";
    }
}
