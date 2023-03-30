using System.Net.Sockets;

namespace Task1.Classes.Details;

public class Ram : Detail
{
    public string Type { get; set; }
    public string Size { get; set; }
    public Ram(decimal price, string supplier, string country,
        string name, string type, string size)
        : base(price, supplier, country, name)
    {
        Type = type;
        Size = size;
    }

    public string GetInfo()
    {
        return $"{Name} | {Size} | {Type} | Price: {Price}";
    }
}
