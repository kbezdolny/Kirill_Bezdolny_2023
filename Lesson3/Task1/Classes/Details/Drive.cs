using System.Net.Sockets;

namespace Task1.Classes.Details;

public class Drive : Detail
{
    public string Size { get; set; }
    public string Speed { get; set; }
    public string Type { get; set; }
    public string Interface { get; set; }
    public string? Lifetime { get; set; }
    public Drive(decimal price, string supplier, string country, string name, string type,
        string size, string speed, string _interface, string? lifetime)
        : base(price, supplier, country, name)
    {
        Size = size;
        Speed = speed;
        Interface = _interface;
        Lifetime = lifetime;
        Type = type;
    }
    public string GetInfo()
    {
        return $"{Name} | {Type} {Interface} | {Speed} | Price: {Price}";
    }
}
