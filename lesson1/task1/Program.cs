// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите первое число:");

// string a = Console.ReadLine();
// int firstNumber = Convert.ToInt32(a);

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int secondNumber = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}

Console.WriteLine("Максимальное число: " + max + " Минимальное число: " + min + ".");