// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[27]; // Инициализация массива
        rndArr(array); // Вызов метода, заполняющего массив, случайными числами.
        Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива: {maxNumber(array) - minNumber(array)}");
    }   // Вывод результата.

    private static void rndArr(int[] array) // Метод, генерирующий случайные числа, для заполнения массива.
    {
        string receivedArray = ""; // Инициализация переменной, хранящей массив в виде строки.
        Random rnd = new Random(); // Инициализация экземпляра класса, генерирующего случайные числа.
        for (int i = 0; i < array.Length; i++) // Запуск цикла, заполняющего массив, случайными числами.
        {
            array[i] = rnd.Next(1, 101); // Установка диапазона, из которого будут выбираться случайные числа.
            receivedArray = receivedArray + array[i] + "; "; // Добавление элементов массива в виде строки.
        }
        Console.WriteLine($"Полученный массив: {receivedArray}"); // Вывод полученного массива.
    }

    private static int minNumber(int[] array) // Метод, для нахождения минимального значения элементов массива.
    {
        int minNum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (minNum > array[i])
            {
                minNum = array[i];
            }
        }
        Console.WriteLine($"Минимальное значение элементов массива: {minNum}.");
        return minNum;
    }
    private static int maxNumber(int[] array) // Метод, для нахождения максимального значения элементов массива.
    {
        int maxNum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (maxNum < array[i])
            {
                maxNum = array[i];
            }
        }
        Console.WriteLine($"Максимально значение элементов массива: {maxNum}.");
        return maxNum;
    }
}