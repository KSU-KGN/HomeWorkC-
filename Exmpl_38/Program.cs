/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
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

double NumToMasDouble(int min, int max)
{
    double res = min + new Random().NextDouble() * (max - min);
    res = Math.Round(res, 2);
    return res;
}

void PrintArray(double[] collection)
{
    Console.Write("[");
    int index;
    for (index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]}; ");
    }
    Console.WriteLine($"{collection[index]}]");
}

double DiffMaxMin(double[] mass, int size)
{
    double min = mass[0];
    double max = min;
    for (int i = 1; i < size; ++i)
    {
        if (mass[i] < min)
        {
            min = mass[i];
        }
        else if (mass[i] > max)
             {
                max = mass[i];
             }
    }
    double diff = max - min;
    return diff;
}

int userCount = StrToInt("Введите размер массива: ");
double[] myMass = new double[userCount];
for (int i = 0; i < userCount; ++i)
{
    myMass[i] = NumToMasDouble(-10, 10);
}
PrintArray(myMass);
double res = DiffMaxMin(myMass, userCount);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {res}");