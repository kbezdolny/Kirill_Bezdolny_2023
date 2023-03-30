using Task1.Classes.Details;
using Task1.Classes;
using System.Text;
using Task1;
using System;

class Shop
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Computer computer = new Computer();
        DetailsStock stock = new DetailsStock();
        decimal budget = 100000;
        decimal startPrice = 0;
        decimal endPrice = budget;
        string menu = "┬────────────<Menu>────────────•" +
                    "\n│ a) Enter budget" +
                    "\n│ b) Check basket" +
                    "\n│ c) Enter price range" +
                    "\n│ d) Display details" +
                    "\n│ e) Add detail to basket" +
                    "\n│ f) Remove detail from basket" +
                    "\n│ g) Build PC" +
                    "\n│ " +
                    "\n│ menu) Call this menu :3" +
                    "\n│ exit) To exit the store" +
                    "\n┴──────────────────────────────•";
        Console.WriteLine(menu + "\n");
        while (true)
        {
            string updatedMenu = "┬────────────<Menu>────────────•" +
                              $"\n│ a) Enter budget ({budget})" +
                               "\n│ b) Check basket" +
                              $"\n│ c) Enter price range({startPrice} - {endPrice})" +
                               "\n│ d) Display details" +
                               "\n│ e) Add detail to basket" +
                               "\n│ f) Remove detail from basket" +
                               "\n│ g) Build PC" +
                               "\n│ " +
                               "\n│ menu) Call this menu :3" +
                               "\n│ exit) To exit the store" +
                               "\n┴──────────────────────────────•";
            Console.Write(">");
            string detileType, detileName, result;
            switch (Console.ReadLine().ToLower()) {
                case "a":
                    Console.Write(">Enter your budget: ");
                    budget = Convert.ToDecimal(Console.ReadLine());
                    break;
                case "b":
                    OutBasket();
                    break;
                case "c":
                    Console.Write(">Enter start price: ");
                    startPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write(">Enter end price: ");
                    endPrice = Convert.ToDecimal(Console.ReadLine());
                    break;
                case "d":
                    OutDetailsStock(startPrice, endPrice);
                    break;
                case "e":
                    Console.Write("Enter detile category(gpu/cpu/..): ");
                    detileType = Console.ReadLine().ToLower();
                    Console.Write("Enter detile name: ");
                    detileName = Console.ReadLine().ToLower();

                    result = computer.AddDetails(detileType, detileName, stock);
                    Console.WriteLine(result == null ? "" : $">>{result}");
                    break;
                case "f":
                    Console.Write("Enter detile category(gpu/cpu/..): ");
                    detileType = Console.ReadLine().ToLower();
                    Console.Write("Enter detile name: ");
                    detileName = Console.ReadLine().ToLower();

                    result = computer.RemoveDetail(detileType, detileName);
                    Console.WriteLine(result == null ? "" : $">>{result}");
                    break;
                case "g":
                    result = computer.Build(budget);
                    Console.WriteLine(result);
                    break;
                case "menu":
                    Console.WriteLine(updatedMenu);
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    continue;
            }
            Console.WriteLine("");
        }

        void OutBasket()
        {
            var details = computer.GetDetails();
            Console.WriteLine("┬────────────<Basket>────────────•");
            foreach (KeyValuePair<string, object> entry in details) {
                Console.WriteLine($"├─<{entry.Key[0].ToString().ToUpper() + entry.Key.Substring(1, entry.Key.Length - 1)}>─────•");

                if (entry.Value is Motherboard mboard) {
                    Console.WriteLine($"│ • {mboard.GetInfo()}");
                }
                else if (entry.Value is List<Detail> detailsList) {
                    foreach (var detail in detailsList)
                    {
                        Console.WriteLine($"│ • {detail.Name}");
                    }
                }
                Console.WriteLine("│");
            }
            Console.WriteLine("┴────────────────────────────────•");
        }

        void OutDetailsStock(decimal startPrice, decimal endPrice)
        {
            Console.WriteLine("┬─────────────────────<Details>─────────────────────•");

            Console.WriteLine("├─<Motherboards>──────────────────•"); ;
            foreach (var mboard in stock.Motherboards.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                                                    .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"│ • {mboard.GetInfo()}");
            }

            Console.WriteLine("│\n├─<Rams>──────────────────────────•");
            foreach (var ram in stock.Rams.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                                          .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"│ • {ram.GetInfo()}");
            }

            Console.WriteLine("│\n├─<Cpus>──────────────────────────•");
            foreach (var cpu in stock.Cpus.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                                          .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"│ • {cpu.GetInfo()}");
            }

            Console.WriteLine("│\n├─<Gpus>──────────────────────────•");
            foreach (var gpu in stock.Gpus.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                                          .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"│ • {gpu.GetInfo()}");
            }

            Console.WriteLine("│\n├─<Drives>────────────────────────•");
            foreach (var drive in stock.Drives.Where(x => x.Price >= startPrice && x.Price <= endPrice)
                                          .OrderBy(x => x.Price).ToList())
            {
                Console.WriteLine($"│ • {drive.GetInfo()}");
            }

            Console.WriteLine("┴───────────────────────────────────────────────────•");
        }
    }
}