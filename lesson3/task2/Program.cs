// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine($"Введите координату первой точки по X"); // Запрос координаты первой точки по Х от пользователя.
int firstPointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату первой точки по Y"); // Запрос координаты первой точки по Y от пользователя.
int firstPointY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату первой точки по Z"); // Запрос координаты первой точки по Z от пользователя.
int firstPointZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координату второй точки по X"); // Запрос координаты второй точки по Х от пользователя.
int secondPointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату второй точки по Y"); // Запрос координаты второй точки по Y от пользователя.
int secondPointY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату второй точки по Z"); // Запрос координаты второй точки по Z от пользователя.
int secondPointZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(secondPointX - firstPointX, 2) + Math.Pow(secondPointY - firstPointY, 2) + Math.Pow(secondPointZ - firstPointZ, 2));

Console.WriteLine($"Расстоние между точками равно: {distance:f2}");