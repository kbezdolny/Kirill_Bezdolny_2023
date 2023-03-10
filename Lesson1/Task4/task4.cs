Console.Write("Enter first string: ");
string firstStr = Console.ReadLine();

Console.Write("Enter second string: ");
string secondStr = Console.ReadLine();

if (firstStr.Length > secondStr.Length) {
    Console.WriteLine(firstStr + secondStr);
}
else if (firstStr.Length < secondStr.Length)
{
    string[] splitStr = secondStr.Split(firstStr[0]);
    Console.Write("[");
    foreach (string str in splitStr) 
        Console.Write($"\"{str}\", ");
    Console.Write("]");
}
else Console.WriteLine("Some void...");