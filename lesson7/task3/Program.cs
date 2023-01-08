// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = new Random().Next(2, 7); // Генератор случайного количества строк, в заданном диапазоне.
int cols = new Random().Next(2, 7); // Генератор случайного количества столбцов, в заданном диапазоне.
int[,] array = getRandomMatrix(rows, cols, 1, 20); // Инициализация массива генератором случайных чисел.
printMatrix(array); // Печать массива в консоль.


int[,] getRandomMatrix(int rows, int columns, int leftRange = 1, int rightRange = 10) // Метод, генерирующий
{                                               // случайные значения элементов массива.
    int[,] matr = new int[rows, columns]; // Цикл заполняющий массив случайными числами.
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(leftRange, rightRange); // Заполнение массива
        }
    }
    return matr;
}

void printMatrix(int[,] matr) // Метод печати массива.
{
    Console.WriteLine($"Полученный массив: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(avgCols(matr)); // Вызов метода, вычисляющего, среднее арифметическое элементов столбца.
}

string avgCols(int[,] arr) // Метод, вычисляющий, среднее арифметическое каждого столбца.
{
    double sum = 0; // Переменная, хранящая сумму элементов, столбца.
    int count = 0; // Счетчик элементов столбца.
    int columnNum = 0; // Счетчик столбцов.
    string result = ""; // Вывод результата в консоль.

    for (int i = 0; i < arr.GetLength(1); i++) // Столбцы
    {
        for (int j = 0; j < arr.GetLength(0); j++) // Строки
        {
            sum += arr[j, i]; // Подсчет суммы элементов столбца.
            count++; // Продвижение счетчика.
            if (count == arr.GetLength(0) + 1) // Выравнивание индекса и счетчика, для корректного перехода к следующему столбцу
            {                                  // и корректного подсчета текущего.
                sum = arr[j, i]; // Начало следующего столбца. 
                count = 1;
            }
        }
        columnNum++;
        result += ($"{columnNum}-го столбца {(sum / count):f2}; "); // Запись вычислений в результат.
    }
    return $"Среднее арифметическое: {result}"; // Результат работы метода.
}