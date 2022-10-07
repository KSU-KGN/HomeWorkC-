/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

void PrintColorData(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(text);
    Console.ResetColor();
}

void PrintArrayTwoDouble(double[,] collection)
{
    Console.Write($"\t");
    for (int i = 0; i < collection.GetLength(1); ++i)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < collection.GetLength(0); ++i)
    {
        for (int j = 0; j < collection.GetLength(1); ++j)
        {
            if (j == 0)
            {
                PrintColorData($"{i}\t");
            }
            Console.Write($"{collection[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int m;
do
{
    m = StrToInt("Введите натуральное число - число строк массива: ");
}
while (m < 1);
int n;
do
{
    n = StrToInt("Введите натуральное число - число столбцов массива: ");
}
while (n < 1);
double[,] arr = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = NumToMasDouble(-10, 10);
    }
}
PrintArrayTwoDouble(arr);