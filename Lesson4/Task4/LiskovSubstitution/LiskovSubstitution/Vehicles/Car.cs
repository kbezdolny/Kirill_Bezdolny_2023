namespace LiskovSubstitution.Vehicles;

public class Car : Vehicle
{
    public Car()
    {
        VehicleType = "Car";
    }
    public override void StartEngine()
    {
        Console.WriteLine("The car engine is starting");
    }
}
