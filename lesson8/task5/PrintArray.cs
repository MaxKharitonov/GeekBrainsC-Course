class PrintArray
{

    public void PrintTwoDimArray(int[,] twoDimArray)
    {
        Console.WriteLine($"Получившийся массив: ");
        Console.WriteLine();
        for (int i = 0; i < twoDimArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimArray.GetLength(1); j++)
            {
                Console.Write(twoDimArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Print(int[] array)
    {
        Console.WriteLine($"Получившийся массив: ");
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine(array[i] + " ");
        }
        Console.WriteLine();
    }
}