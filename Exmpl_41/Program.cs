/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
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

void PrintArray(int[] collection)
{
    int index;
    for (index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[index]}");
}

int Positive(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; ++i)
    {
        if (mass[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int userCount;
do
{
    userCount = StrToInt("Введите натуральное число: ");
}
while (userCount < 1);
int[] mas = new int[userCount];
for (int i = 0; i < userCount; ++i)
{
    mas[i] = StrToInt($"Введите {i + 1}-е число: ");
}
PrintArray(mas);
int res = Positive(mas);
Console.WriteLine($"Чисел больше 0 всего {res}");