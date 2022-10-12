/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
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

int RandomNum(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
}

int MinSum(int[,] mas, int row, int col, int size)
{
    int res = -1, sum;
    int minSum = size * col + 1; //максимально возвозможная сумма + 1
    for (int i = 0; i < row; ++i)
    {
        sum = 0;
        for (int j = 0; j < col; ++j)
        {
            sum += mas[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            res = i;
        }
    }
    return res;
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
int size = 10;
int[,] arr = new int[m, n];
for (int i = 0; i < m; ++i)
{
    for (int j = 0; j < n; ++j)
    {
        arr[i, j] = RandomNum(-size, size);
    }
}
PrintArrayTwo(arr);
int res = MinSum(arr, m, n, size);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {res} строка");