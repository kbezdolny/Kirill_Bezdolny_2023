using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Vehicle : IMoveable
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

    public virtual void Move()
    {
        Console.WriteLine("It's moving?");
    }
}
