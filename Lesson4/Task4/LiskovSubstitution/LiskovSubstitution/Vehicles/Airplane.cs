namespace LiskovSubstitution.Vehicles;

public class Airplane : Vehicle
{
    public Airplane()
    {
        VehicleType = "Airplane";
    }
    public override void StartEngine()
    {
        Console.WriteLine("The airplane engine is starting");
    }

    public override void Move()
    {
        Console.WriteLine("It's flying?");
    }
}
