/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

void IncreasePairs(int[] mass, int size)
{
    int res, i;
    int newSize = size / 2;
    for (i = 0; i < newSize; ++i)
    {
        res = mass[i] * mass[size - i - 1];
        Console.Write($"{res} ");
    }
    if (size % 2 != 0)
    {
        Console.Write(mass[i]);
    }
}

int userCount = StrToInt("Введите размер массива: ");
int[] myMass = new int[userCount];
for (int i = 0; i < userCount; ++i)
{
    myMass[i] = NumToMas(1, 10);
}
PrintArray(myMass);
IncreasePairs(myMass, userCount);