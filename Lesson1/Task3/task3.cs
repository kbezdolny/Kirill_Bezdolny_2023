const int listSize = 10;
List<int> numbersList = new List<int>();

for (int i = 0; i < listSize; i++) {
    Console.Write($"Enter {i+1} number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    numbersList.Add(number);
}

Console.Write($"Enter last number: ");
int dublicateNumber = Convert.ToInt32(Console.ReadLine());

if (numbersList.Contains(dublicateNumber))
    numbersList.Add(dublicateNumber);

foreach (int n in numbersList) 
    Console.Write($"{n}, ");