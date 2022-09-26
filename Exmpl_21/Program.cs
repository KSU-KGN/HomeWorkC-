int getQuartCatet(int p1, int p2)
{
    int res = (p2 - p1) * (p2 - p1);
    return res;
}

int StrToInt(string text)
{
    int res;
    string userLine;
    do
    {
        Console.WriteLine(text);
        userLine = Console.ReadLine();
    }
    while (int.TryParse(userLine, out res) == false);
    return res;
}

int xA, xB, yA, yB, zA, zB;
xA = StrToInt("Введите число X точки A: ");
yA = StrToInt("Введите число Y точки A: ");
zA = StrToInt("Введите число Z точки A: ");
xB = StrToInt("Введите число X точки B: ");
yB = StrToInt("Введите число Y точки B: ");
zB = StrToInt("Введите число Z точки B: ");

double gipotenuza = Math.Sqrt(getQuartCatet(xA, xB) + getQuartCatet(yA, yB) + getQuartCatet(zA, zB));

Console.WriteLine(gipotenuza);