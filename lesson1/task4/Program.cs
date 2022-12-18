// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");

int n = Convert.ToInt32(Console.ReadLine());

int even;

string evenNums = ("Четные числа:");

if (n <= 0)
{
    Console.WriteLine("Ошибка: Число не может быть меньше или равно 0..");
    return;
}

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Convert.ToString(even = i);
        evenNums = evenNums + (" " + even + "; ");
    }
}
Console.WriteLine(evenNums);