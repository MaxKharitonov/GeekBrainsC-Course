// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0, 0, 1)
// 45(1, 0, 0) 53(1, 0, 1)
// int a = new Random().Next(1, 9);
// int b = new Random().Next(1, 9);
// int c = new Random().Next(1, 9);

int[,,] array = new int[9, 5, 2];
int number = 10;

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            array[i, j, k] = number;
            number++;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]}[{i},{j},{k}]");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}