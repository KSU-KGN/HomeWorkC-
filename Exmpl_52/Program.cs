/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintColorData(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(text);
    Console.ResetColor();
}

void PrintArrayTwo(int[,] collection)
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

void PrintArrayOneDouble(double[] collection)
{
    int index;
    for (index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]}; ");
    }
    Console.Write($"{collection[index]}");
}

int RandomNum(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
}

double[] AvgArrayColomn(int[,] array, int row, int col)
{
    double[] result = new double[col];
    int sum;
    for (int i = 0; i < col; ++i)
    {
        sum = 0;
        for (int j = 0; j < row; ++j)
        {
            sum += array[j, i];
        }
        result[i] = Math.Round((double)sum / row, 2);
    }
    return result;
}

int m = 0;
while (m < 1)
{
    m = StrToInt("Введите натуральное число - число строк массива: ");
}
int n = 0;
while (n < 1)
{
    n = StrToInt("Введите натуральное число - число столбцов массива: ");
}
int[,] arr = new int[m, n];
for (int i = 0; i < m; ++i)
{
    for (int j = 0; j < n; ++j)
    {
        arr[i, j] = RandomNum(-10, 10);
    }
}
PrintArrayTwo(arr);
double[] avg = AvgArrayColomn(arr, m, n);
PrintArrayOneDouble(avg);