using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles;

public class Airplane : Vehicle, IFlyable
{
    public Airplane()
    {
        VehicleType = "Airplane";
    }
    public override void StartEngine()
    {
        Console.WriteLine($"The {VehicleType} engine is starting");
    }

    public void Flyable()
    {
        Console.WriteLine("It's flying?");
    }
}
