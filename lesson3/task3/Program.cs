// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num];
int cube = 1;
string cubes = " ";

for (int i = 1; i < arr.Length + 1; i++)
{
    cube = (i * i) * i;
    // Console.WriteLine($"Cubes: {cube}");
    cubes = cubes + (cube + "; ");
    // Console.WriteLine($"Cubes: {cubes}");
}
Console.WriteLine($"Список чисел в кубе, в диапазоне от 1 до заданного числа {num}: {cubes}");