// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void printNumbers(int min, int max) //  Рекурсивный метод, выводящий числа от М до N.
{
    if (min > max) //  Условие остановки рекурсии.
    {
        return; //  Завершение программы.
    }
    else
    {
        Console.Write(min + " "); //  Вывод чисел в консоль.
        printNumbers(min + 1, max);    //  Вызов метода заново, увеличение стартового числа на 1.
    }
}

int m = new Random().Next(1, 99);   //  Инициализация переменной, хранящей первое число.
Console.WriteLine();
Console.WriteLine($"Первое число: {m}");
Console.WriteLine();
int n = new Random().Next(1, 99);   //  Инициализация переменной, хранящей второе число.
Console.WriteLine($"Второе число: {n}");
Console.WriteLine();
if (m == n) //  Проверка на равенство чисел.
{
    Console.WriteLine();
    Console.WriteLine($"Числа равны.");  //  Если числа равны, завершение выполнения программы.
    Console.WriteLine();
    return;
}
else    //  Если числа не равны, продолжение выполнения программы.
{
    int number; //  Объявление переменной, в которую будут передаваться числа от M до N для вывода в консоль.
    int max;    //  Объявление переменной, в которой будет храниться максимальное из чисел M и N.
    if (m < n)  //  Если число m меньше числа n;
    {
        number = m; //  Присваивание меньшего из чисел M и N переменной, в качестве стартового числа.
        max = n;    //  Присваивание большего из чисел переменной, в качестве последнего числа.
        Console.WriteLine($"Полученные числа: ");
        Console.WriteLine();
        printNumbers(number, max);   //  Вызов рекурсивного метода, выводящего числа от М до N.
        Console.WriteLine();
        Console.WriteLine();
    }
    else    // То же самое, только наоборот.
    {
        number = n;
        max = m;
        Console.WriteLine($"Полученные числа: ");
        Console.WriteLine();
        printNumbers(number, max);
        Console.WriteLine();
        Console.WriteLine();
    }
}