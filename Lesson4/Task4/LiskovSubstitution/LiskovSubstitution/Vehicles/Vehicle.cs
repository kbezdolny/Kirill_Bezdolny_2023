namespace LiskovSubstitution.Vehicles;

public class Vehicle
{
    protected string? VehicleType { get; set; }
    public Perfomance? Perfomance { get; set; }

    public string? GetVehicleType()
    {
        return VehicleType;
    }
    public virtual void StartEngine()
    {
        Console.WriteLine("The engine is starting");
    }
}
