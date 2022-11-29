Console.Clear();
Console.WriteLine("введи пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int numberOne = number / 10000;
int numberTwo = number / 1000 % 10;
int numberFour = number / 10 % 10;
int numberFive = number % 10;
if ((number<10000) || (number>99999)) // проверка корректности ввода
{
    Console.WriteLine("Некорректный ввод числа");
}
else
{
    if ((numberOne == numberFive) && (numberTwo == numberFour))
    {
        Console.WriteLine("Данное число-палиндром");
    }
    else
    {
        Console.WriteLine("Данное число-не палиндром");
    }
}
