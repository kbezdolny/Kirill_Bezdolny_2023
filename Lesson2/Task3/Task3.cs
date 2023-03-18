var customersList = new List<Customer>() {
    new Customer("Nick", 22, "Address1"),
    new Customer("Jone", 16, "Address2"),
    new Customer("Harry", 35, "Address3"),
    new Customer("Charley", 64, "Address4"),
    new Customer("Oscar", 25, "Address5"),
    new Customer("George", 87, "Address6"),
    new Customer("Charley", 12, "Address7"),
    new Customer("Thomas", 33, "Address8"),
    new Customer("Nick", 11, "Address9"),
    new Customer("Harry", 44, "Address10")
};
Console.WriteLine(">>>List of customers:");
foreach(var customer in customersList) {
    Console.WriteLine($"> {customer.name} - {customer.age} years - {customer.address}");
}
Console.Write("\n\n>>>Enter the name of the required customers: ");
var name = Console.ReadLine();

Console.WriteLine("\n>>>Selected customers:");
var selectedCustomers = from c in customersList where c.name == name && c.age > 18 select c;
foreach (var customer in selectedCustomers) {
    Console.WriteLine($"> {customer.name} - {customer.age} years - {customer.address}");
}


class Customer {
    public string name;
    public int age;
    public string address;
    public Customer(string name, int age, string address) {
        this.name = name;
        this.age = age;
        this.address = address;
    }
}
