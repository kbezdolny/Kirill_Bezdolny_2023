var productsList = new List<Product>() {
    new Product("Apple", 10.2),
    new Product("Orange", 9.2),
    new Product("Milk", 35.8),
    new Product("Cheese", 25.7),
    new Product("Yogurt", 46.3),
    new Product("Bread", 20.6),
    new Product("Tomato", 4.5),
    new Product("Cucumber", 3.3),
    new Product("Oil", 60.4),
    new Product("Meat", 20.0)
};

var SortingList = productsList.OrderBy(x => x.Price);
Console.WriteLine(">>>Sorting product list: ");
foreach (var product in SortingList) {
    Console.WriteLine($"{product.Name} — {product.Price} UAH");
}

Console.WriteLine("\n>>>Revers sorting product list: ");
foreach (var product in SortingList.Reverse()) {
    Console.WriteLine($"{product.Name} — {product.Price} UAH");
}

class Product {
    public string Name { get; }
    public double Price { get; }
    public Product(string name, double price) {
        Name = name;
        Price = price;
    }
}