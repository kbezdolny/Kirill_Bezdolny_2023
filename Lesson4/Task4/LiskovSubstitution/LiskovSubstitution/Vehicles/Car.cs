using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Car : Vehicle, IDriveable
{
    public Car()
    {
        VehicleType = "Car";
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
