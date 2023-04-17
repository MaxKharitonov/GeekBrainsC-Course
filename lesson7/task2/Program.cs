// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int rowsNumber = new Random().Next(1, 10); // Генерация случайного количества строк массива.
int columnsNumber = new Random().Next(1, 10); // Генерайция случайного количества столбцов массива.
int[,] array = getRandomMatrix(rowsNumber, columnsNumber, -100, 100); // Инициализация массива, с помощью метода.
printMatrix(array); // Метод вывода массива в консоль.

Console.WriteLine($"Введите индекс строки: "); // Запрос индекса строки от пользователя.
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Введите индекс столбца: "); // Запрос индекса столбца от пользователя.
int columnIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(findElement(array, rowIndex, columnIndex)); // Вывод результата работы программы.

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
}

string findElement(int[,] arr, int row, int column) // Основной метод.
{
    for (int i = 0; i < arr.GetLength(0); i++) // Запуск цикла.
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i.Equals(row - 1) && j.Equals(column - 1)) // Сравнение заданных пользователем индексов с индексами массива. 
            {
                return $"Значение элемента массива по заданным индексам: {arr[i, j]}.";
            }
            // else if (!i.Equals(row - 1) && j.Equals(column - 1))
            // {
            //     return $"Строка с индексом {row} в массиве не существует. \nЗначение элемента не может быть найдено, элемент не существует в массиве...";
            // }
            // else if (i.Equals(row - 1) && !j.Equals(column - 1))
            // {
            //     return $"Столбец с индексом {column} в массиве не существует. \nЗначение элемента не может быть найдено, элемент не существует в массиве...";
            // }
            // else
            // {
            //     return $"Строка и столбец с индексами ({row}, {column}) в массиве не существуют. \nЗначение элемента не может быть найдено, элемент не существует в масиве...";
            // }
        }
    }
    return $"Элемента с индексами ({row}, {column}), в массиве не существует. \nЗначение элемента не может быть найдено...";
}