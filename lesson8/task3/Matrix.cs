class Matrix // Класс, в котором будет генерироваться двумерный массив.
{
    private int[,] values; // Объявление приватного массива.

    public Matrix(int[,] values) // Конструктор класса.
    {
        this.values = values;
    }

    public void Print() // Публичный метод класса, печатающий массив в консоль.
    {
        Console.WriteLine($"Получившийся массив: ");
        Console.WriteLine();
        for (int i = 0; i < values.GetLength(0); i++)
        {
            for (int j = 0; j < values.GetLength(1); j++)
            {
                Console.Write(values[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Print(int[,] values)
    {
        Console.WriteLine($"Получившийся массив: ");
        Console.WriteLine();
        for (int i = 0; i < values.GetLength(0); i++)
        {
            for (int j = 0; j < values.GetLength(1); j++)
            {
                Console.Write(values[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static int[,] getRandomMatrix(int rows, int cols, int leftRange = 1, int rightRange = 15)
    {                                               //  Метод, генерирующий случайную матрицу.
        int[,] array = new int[rows, cols];         //  Инициализация пустого массива.
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(leftRange, rightRange); //  Заполнение массива
                                                                        //  случайными элементами.
            }
        }
        return array;
    }
    public static Matrix operator *(Matrix a, Matrix b) // Публичный метод класса, умножающий 2 массива.
    {
        int n = a.values.GetLength(0);  //  Инициализация переменной, которая будет хранить длину 
                                        //  строки переданного массива.
        int m = a.values.GetLength(1);  //  Инициализация переменной, которая будет хранить длину
                                        //  столбца переданного массива.
        int p = b.values.GetLength(1);  //  Инициализация переменной, которая будет хранить длину
                                        //  столбца второго переданного массива.

        int[,] result = new int[n, p];  //  Инициализация массива, в который будет сохранен
                                        //  результат умножения массивов.
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                int multiply = 0;
                for (int k = 0; k < m; k++)
                {
                    multiply = a.values[i, j] * b.values[i, j];
                }
                result[i, j] = multiply;
            }
        }

        return new Matrix(result);
    }
}