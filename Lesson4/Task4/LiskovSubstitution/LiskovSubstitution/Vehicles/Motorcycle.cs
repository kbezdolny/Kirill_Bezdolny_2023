namespace LiskovSubstitution.Vehicles;

public class Motorcycle : Vehicle
{
    public Motorcycle()
    {
        VehicleType = "Motorcycle";
    }
    public override void StartEngine()
    {
        Console.WriteLine("The motorcycle engine is starting");
    }
}
