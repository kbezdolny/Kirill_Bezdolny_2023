using LiskovSubstitution.Vehicles;

List<Vehicle> vehicles = new List<Vehicle>
{
    new Vehicle(),
    new Car(),
    new Airplane(),
    new Motorcycle()
};

foreach(var vehicle in vehicles)
{
    Console.WriteLine($"Your vehicle is {vehicle.GetVehicleType()}!");
}
