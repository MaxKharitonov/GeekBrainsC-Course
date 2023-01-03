// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        int number;


        while (true) // Запуск бесконечного цикла ввода чисел от пользователя.
        {
            Console.WriteLine($"Чтобы остановить программу, введите 'stop'");
            Console.WriteLine($"Введите число: "); // Запрос ввода от пользователя. 
            string command = Console.ReadLine();

            if (command.Equals("stop"))
            {
                Console.WriteLine($"Введена команда 'stop' \nЗавершение программы...");
                Console.WriteLine($"Количество введеных чисел больше 0: {count}");
                break;
            }
            else
            {
                number = Convert.ToInt32(command);
                if (number > 0)
                {
                    count++;
                }
            }
        }
    }
}