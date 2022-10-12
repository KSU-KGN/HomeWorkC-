/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

void PrintArrayFree(int[,,] collection)
{
    for (int k = 0; k < collection.GetLength(2); ++k)
    {
        for (int i = 0; i < collection.GetLength(0); ++i)
        {
            for (int j = 0; j < collection.GetLength(1); ++j)
            {
                if (k % 2 != 0)
                {
                    PrintColorData($"{collection[i, j, k]}({i}, {j}, {k})\t");
                }
                else
                {
                    Console.Write($"{collection[i, j, k]}({i}, {j}, {k})\t");
                }
            }
            Console.WriteLine();
        }
    }
}

int RandomNum(int min, int max)
{
    int num = new Random().Next(min, max + 1);
    return num;
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
int k = 0;
while (k < 1)
{
    k = StrToInt("Введите натуральное число - глубину массива: ");
}
int size = m * n * k;
if (size > 90)
{
    Console.WriteLine($"Трёхмерный массив [{m}, {n}, {k}] из неповторяющихся двузначных чисел нельзя сформировать");
}
else
{
    int[,,] arr = new int[m, n, k];
    bool[] notRepeat = new bool[size + 1];
    int randomArr;
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            for (int l = 0; l < k; ++l)
            {
                do
                {
                    randomArr = RandomNum(10, 9+size);
                }
                while (notRepeat[randomArr-10]);
                notRepeat[randomArr-10] = true;
                arr[i, j, l] = randomArr;
            }
        }
    }
    PrintArrayFree(arr);
}