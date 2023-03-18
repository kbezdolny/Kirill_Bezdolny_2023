var personsList = new List<Person>() {
    new Person("Nick", 22),
    new Person("Jone", 16),
    new Person("Harry", 35),
    new Person("Jack", 64),
    new Person("Oscar", 25),
    new Person("George", 87),
    new Person("Charley", 12),
    new Person("Thomas", 33)
};

Console.Write("Enter start age: ");
int startAge = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter start age: ");
int endAge = Convert.ToInt32(Console.ReadLine());

var selectedPersons = from p in personsList where p.Age >= startAge && p.Age <= endAge select p;
foreach(Person person in selectedPersons) {
    Console.WriteLine($"> {person.Name} - {person.Age}");
}

class Person {
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }   
}