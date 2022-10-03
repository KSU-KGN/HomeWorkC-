/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int NumToMas(int min, int max)
{
    int res = new Random().Next(min, max + 1);
    return res;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    int index;
    for (index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[index]}]");
}

int CountEven(int[] mass, int size)
{
    int count = 0;
    for (int i = 0; i < size; ++i)
    {
        if (mass[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int userCount = StrToInt("Введите размер массива: ");
int[] myMass = new int[userCount];
for (int i = 0; i < userCount; ++i)
{
    myMass[i] = NumToMas(100, 999);
}
PrintArray(myMass);
int res = CountEven(myMass, userCount);
Console.WriteLine($"Количество чётных чисел в массиве равно {res}");