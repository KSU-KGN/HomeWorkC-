Console.WriteLine("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA < numB)
{
    Console.WriteLine($"max = {numB}, min = {numA}");
}
else
{
    Console.WriteLine($"max = {numA}, min = {numB}");
}