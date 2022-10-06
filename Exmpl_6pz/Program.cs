/*
*Задача(сложная не на оценку) *
Напишите программу, котрая находит подмножество данного множества чисел такое, 
что сумма его элементов равна заданному числу
*/
int[] mas = new int[] {1, 4, 6, -2};
bool[] bool_mas = new bool[] {false, false, false, false};

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

void PrintArray(string text, int[] collection)
{
    int index;
    Console.WriteLine(text);
    for (index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[index]}");
}

int PrintArrayBool(string text, bool[] collection, int[] mass)
{
    string result = "";
    int count = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index])
        {
            if (count == 0)
            {
                result += $"{mass[index]}";
            }
            else
            {
                result += $", {mass[index]}";
            }
            count++;
        }
    }
    if (count > 0)
    {
        Console.WriteLine(text);
        Console.WriteLine(result); 
    }
    return count;
}
 
bool FoundPod(int ish_sum, int indx, int new_sum, int count)
{
    if (count == 1 && indx < 4)
    {
        bool_mas[indx + 1] = true;
    }
    if (count == -1 && indx < 4)
    {
        bool_mas[indx + 1] = false;
    }
    if (new_sum == ish_sum) 
    {
        int flag = PrintArrayBool($"Найдено подмножество с суммой элементов {ish_sum}:", bool_mas, mas);
        if (flag == 0)
        {
            return false; 
        }
        else
        {
            return true;
        }
    }
    if (indx < 0)
    {
        return false;
    }
    bool add_mass = FoundPod(ish_sum, indx - 1, new_sum + mas[indx], 1);
    bool sub_mass = FoundPod(ish_sum, indx - 1, new_sum, -1);
    if (add_mass || sub_mass)
    {
        return true;
    }
    else
    {
        return false;
    }
}

PrintArray("Заданно множество чисел", mas);
int user_sum = StrToInt("Введите сумму для поиска подмножества:");
int num_len = mas.Length - 1;
bool res = FoundPod(user_sum, num_len, 0, 0);
if (!res)
{
    Console.WriteLine($"Подмножеств с суммой элементов {user_sum} не обнаружено");  
}