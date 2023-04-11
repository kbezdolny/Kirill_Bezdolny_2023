using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Motorcycle : Vehicle, IDriveable
{
    public Motorcycle()
    {
        VehicleType = "Motorcycle";
    }
    public override void StartEngine()
    {
        Console.WriteLine($"The {VehicleType} engine is starting");
    }

    public void Driveable()
    {
        Console.WriteLine("It's driving?");
    }
}
