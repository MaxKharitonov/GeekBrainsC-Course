// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine($"Введите число: "); // Запрос числа от пользователя.
int number = Convert.ToInt32(Console.ReadLine());
char[] numberArray = number.ToString().ToCharArray(); // Перевод, введенного числа, в чар-массив.
if (numberArray[0].Equals('-')) // Проверка на отрицательное число.
{
    Console.WriteLine($"Внимание! Только положительные числа допустимы!\nЗамена минуса на ноль!");
    numberArray[0] = '0'; // Замена минуса на ноль. 
    Console.Write("Новое число: ");
    Console.WriteLine(numberArray);
}
int result = 0; // Инициализация переменной, хранящей результат.
for (int i = 0; i < numberArray.Length; i++) // Запуск цикла, суммирующего элементы массива.
{
    int num = Convert.ToInt32(numberArray[i].ToString()); // Преведение элемента массива чар типа к целочисленному.
    result = num + result; // Суммирование цифр введенного числа.
}
Console.WriteLine($"Сумма цифр числа: {result}"); // Вывод результата работы программы.