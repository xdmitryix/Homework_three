Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int count = 1;
int number = DataEntry("введи число: ");
while (count < number + 1)
{
    double result = Math.Pow(count, 3);
    if (count == number)
    {
        Console.Write($"{result}");
    }
    else
    {
        Console.Write($"{result},");
    }
    count++;
}