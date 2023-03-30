namespace Task1.Classes.Details;

public class Motherboard : Detail
{
    public string Socket { get; set; }
    public decimal RamSlotsCount { get; set; }
    public string RamSlotType { get; set; }

    public Dictionary<string, int> Interfaces = new Dictionary<string, int>();

    public Motherboard(decimal price, string supplier, string country, string name,
        string socket, decimal ramSlotsCount, string ramSlotType, Dictionary<string, int> interfaces)
        : base(price, supplier, country, name)
    {
        Socket = socket;
        RamSlotsCount = ramSlotsCount;
        RamSlotType = ramSlotType;
        Interfaces = interfaces;
    }

    public string GetInfo()
    {
        return $"{Name} | {Socket} | {RamSlotsCount}-{RamSlotType} | Price: {Price}";
    }
}
