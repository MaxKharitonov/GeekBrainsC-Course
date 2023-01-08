// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. ​
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rowsCount = readInt($"Введите количество строк: "); // Запрос количества строк от пользователя.
Console.WriteLine();
int columnsCount = readInt($"Введите количество столбцов: "); // Запрос количества столбцов от пользователя.
Console.WriteLine();

double[,] array = getRandomMatrix(rowsCount, columnsCount, -10, 50); // Инициализация массива.
printMatrix(array); // Вывод готового массива.

int readInt(string message) // Метод считывающий введенные пользователем значения строк и столбцов.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] getRandomMatrix(int rows, int columns, int leftRange = 1, int rightRange = 10) // Метод, генерирующий
{                                               // случайные значения элементов массива.
    double[,] matr = new double[rows, columns]; // Цикл заполняющий массив случайными числами.
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(leftRange, rightRange)) / 10; // Заполнение массива
        }                                       // и получение вещественных чисел.
    }
    return matr;
}

void printMatrix(double[,] matr) // Метод печати массива.
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
}