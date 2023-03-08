const int listSize = 10;
List<int> numbersList = new List<int>();

for (int i = 0; i < listSize; i++) {
    Console.Write($"Enter {i+1} number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    numbersList.Add(number);
}

for (int i = 0; i < listSize; i++) {
    int numberCount = numbersList.Count(num => {
        return num == numbersList[i];
    });
    if (numberCount > 1 && numbersList.LastIndexOf(numbersList[i]) <= 9)
        numbersList.Add(numbersList[i]);
}

foreach (int n in numbersList) 
    Console.Write($"{n}, ");
