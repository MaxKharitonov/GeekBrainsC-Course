// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = getRandomArray(new Random().Next(3, 5), new Random().Next(3, 5), 1, 15);
printArray(array);
findRowsMinSum(array);


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

void findRowsMinSum(int[,] array) // Метод, находящий строку, с минимальной суммой элементов. 
{
    int result = int.MaxValue; // Инициализация переменной, которая будет хранить минмальную сумму элементов строки.
    int sum = 0; // Инициализация переменной, которая будет хранить сумму элементов строки.
    int count = 0; // Инициализация переменной, которая будет считать строки массива.
    string printResult = ""; // Инициализация переменной, которая будет хранить строку с результатом. 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; // Суммирование элементов строки.
        }
        count++;
        if (result > sum) // Сравнение сумм строк.
        {
            result = sum; // Присваивание минимальной суммы строке.
            printResult = $"Строка с минимальной суммой элементов: {count}"; // Результат в виде строки.
        }
        // Console.WriteLine($"Сумма {count}-й строки: {sum}");
        sum = 0; // Обнуление переменной, хранящей сумму элементов строки.
    }
    Console.WriteLine(printResult); // Вывод результата работы программы.
}