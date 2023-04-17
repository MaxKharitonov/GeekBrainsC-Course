// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine($"Введите первое число: "); // Запрос ввода первого числа от пользователя.
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число: "); // Запрос ввода второго числа от пользователя.
int exponent = Convert.ToInt32(Console.ReadLine());
int result = number; // Инициализация переменной, хранящую результат вычислений.
for (int i = 1; i < exponent; i++) // Запуск цикла.
{
    result = result * number; // Возведение числа в степень.
}
Console.WriteLine(result); // Вывод результата.