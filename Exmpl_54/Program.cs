/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен 
наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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

void DownGrade(int[,] mas, int row, int col)
{
    int tmp;
    for (int i = 0; i < row; ++i)
    {
        for (int j = 1; j < col; ++j)
        {
            if (mas[i, j - 1] < mas[i, j])
            {
                tmp = mas[i, j - 1];
                mas[i, j - 1] = mas[i, j];
                mas[i, j] = tmp;
                j = 0;
            }
        }
    }
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
DownGrade(arr, m, n);
PrintArrayTwo(arr);