namespace Task1.Classes;
public class Detail
{
    public decimal Price { get; set; }
    public string Supplier { get; set; }
    public string Country { get; set; }
    public string Name { get; set; }
    public Detail(decimal price, string supplier, string country, string name)
    {
        Price = price;
        Supplier = supplier;
        Country = country;
        Name = name;
    }
}
