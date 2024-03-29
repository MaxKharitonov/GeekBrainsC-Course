﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float b1, k1, b2, k2;
// k1, k2 - угловые коэффициенты прямых.
// b1, b2 - Пересечение прямых с осью y.
float x, y;// y2;

Console.WriteLine($"Введите значение пересечения оси y, для первой прямой: ");
b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение углового коэффициента первой прямой: ");
k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение пересечения оси y, для второй прямой: ");
b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение углового коэффициента второй прямой: ");
k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine($"Прямые совпадают.");
}
else if (k1 == k2)
{
    Console.WriteLine($"Прямые параллельны и не могут пересекаться.");
}
else
{
    x = (b2 - b1) / (k1 - k2); // Находим координату пересечения прямых по оси x.
    y = k1 * x + b1; // Находим координату пересечения прямых по оси y.
                     // y2 = k2 * x + b2; // Находим координату пересечения прямых по оси y.
    Console.WriteLine($"Прямые пересекаются в точке: ({x:f1}; {y:f1}).");
}