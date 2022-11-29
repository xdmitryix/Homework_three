Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double Findnumber(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}


int x1 = DataEntry("введи x1: ");
int y1 = DataEntry("введи y1: ");
int z1 = DataEntry("введи z1: ");
int x2 = DataEntry("введи x2: ");
int y2 = DataEntry("введи y2: ");
int z2 = DataEntry("введи z2: ");


double resultexit = Findnumber(x1, y1, z1, x2, y2, z2);
Console.WriteLine(resultexit);