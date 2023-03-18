var ownersList = new List<Owner>() {
    new Owner(0, "Nick", "Address1"),
    new Owner(1, "Jone", "Address2"),
    new Owner(2, "Harry", "Address3"),
    new Owner(3, "Charley", "Address4")
};
var carsList = new List<Car>() {
    new Car("43AG32", 2),
    new Car("66BB66", 3),
    new Car("98YU17", 0),
    new Car("91AW92", 1)
};
Console.WriteLine(">>>List of owners:");
foreach(var owner in ownersList) {
    Console.WriteLine($"> {owner.id} - {owner.name} - {owner.address}");
}

Console.WriteLine("\n>>>List of cars:");
foreach (var car in carsList) {
    Console.WriteLine($"> {car.number} - {car.ownerId}");
}
Console.Write("\n\n>>>Enter the car number: ");
var carNumber = Console.ReadLine();

var selectedOwner = from c in carsList from o in ownersList where c.number == carNumber where o.id == c.ownerId select o;

Console.WriteLine("\n>>>Selected owner:");
foreach (var owner in selectedOwner) {
    Console.WriteLine($"> {owner.name} - {owner.address}");
}

class Owner {
    public int id { get; }
    public string name { get; }
    public string address { get; }
    public Owner(int id, string name, string address) {
        this.id = id;
        this.name = name;
        this.address = address;
    }
}

class Car {
    public string number { get; }
    public int ownerId { get; }
    public Car(string number, int ownerId) {
        this.number = number;
        this.ownerId = ownerId;
    }   
}
