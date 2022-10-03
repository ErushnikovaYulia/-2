// Напишите программу, которая на вход принимает два числа и выдает, какое число большее,
// а какое меньшее.

Console.Clear();
Console.WriteLine("Ввведите первое число:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y = int.Parse(Console.ReadLine());
if (x>y)
{
    Console.WriteLine($"{x} больше {y}!");
}
else
{
    Console.WriteLine ($"{x} меньше {y}!");
}

