// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] array = getRandomArray(new Random().Next(3, 5), new Random().Next(3, 5), 1, 15);
printArray(array);
sortArray(array);
printResult(array);

int[,] getRandomArray(int rows, int columns, int leftRange = 1, int rightRange = 10) // Метод, генерирующий
{                                               // случайные значения элементов массива.
    int[,] array = new int[rows, columns]; // Цикл заполняющий массив случайными числами.
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange); // Заполнение массива
        }
    }
    return array;
}

void printArray(int[,] array) // Метод печати массива.
{
    Console.WriteLine($"Полученный массив: ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] sortArray(int[,] arr)
{
    // цикл по строкам
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // сортировка элементов строки
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] > arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

void printResult(int[,] array)
{
    // вывод отсортированного массива
    Console.WriteLine($"Отсортированный массив: ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}