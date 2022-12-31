﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random(); // Инициализация экземпляра класса, генерирующего случайные числа.
        int[] array = new int[123]; // Инициализация массива длиной 123 элемента.
        int count = 0; // Инициализация счетчика.
        string receivedArray = ""; // Инициализация переменной, хранящей заполненный массив в виде строки.
        for (int i = 0; i < array.Length; i++) // Запуск цикла, заполняющего массив случайными числами.
        {
            array[i] = rnd.Next(0, 151); // Ограничение диапазона, из которого возьмутся случайные числа.
            receivedArray = receivedArray + array[i] + "; "; // Запись новых элементов массива в виде строки.
            if (array[i] > 9 && array[i] < 100) // Проверка значений элементов массива на принадлежность
            {                                   // к заданному отрезку значений массива.
                count++;
                // Console.WriteLine($"{count}; Значение: {array[i]}.");
            }
        }
        Console.WriteLine($"Полученный массив: {receivedArray}."); // Вывод, полученного массива в консоль, в виде строки.
        Console.WriteLine($"Количество элементов массива, на отрезке [10,99]: {count}."); // Вывод результата.
    }
}