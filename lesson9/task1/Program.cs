// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

selectOption(menu());   //  Запуск программы.

static int menu()   //  Метод, выводящий меню в консоль.
{
    Console.WriteLine($"\nВвести или сгенерировать число?\n");  //  Пункты меню.
    Console.WriteLine($"1 - Ввести");
    Console.WriteLine($"2 - Сгенерировать");
    Console.WriteLine($"0 - Выход\n");
    int key = Convert.ToInt32(Console.ReadLine());  //  Запрос ввода от пользователя.
    return key;
}

static void selectOption(int key)   //  Метод, обрабатывающий ввод от пользователя.
{
    Console.WriteLine($"\nВвeдена команда: {key}");   //  Информационное сообщение.
    int number; //  Объявление переменной, в которую будет записано число.
    while (true)    //  Запуск бесконечного цикла.
    {   //  Можно расписать через while != 0, чтобы запускать программу, пока не будет введен 0.
        if (key == 1)   //  Введена команда 1.
        {
            number = userInput();   //  Вызов метода ввода числа от пользователя.
            Console.WriteLine($"\nНатуральные числа от {number} до 1: \n"); //  Вывод результата.
            outputNumbers(number);  //  Вызов метода рекурсивного, находящего числа, в заданном диапазоне.
            Console.WriteLine("\n");
            break;  //  Завершение программы.
        }
        else if (key == 2)  //  Введена команда 2.
        {
            number = randomNumber();    // Вызов метода, генерирующиего случайное число.
            Console.WriteLine($"\nНатуральные числа от {number} до 1: \n"); //  Вывод результата.
            outputNumbers(number);  //  Вызов рекурсивного метода, находящего числа, в заданном диапазоне.
            Console.WriteLine("\n");
            break;  //  Завершение программы.
        }
        else if (key == 0)  //  Введена команда 0.
        {
            Console.WriteLine($"\nЗаершение программы..\n");    // Информационное сообщение.
            break;  //  Завершение программы.
        }
        else    //  Ввод неизвестной команды.
        {
            Console.WriteLine($"\nОшибка! Введена неизвестная команда!\n"); //  Вывод ошибки.
            break;
        }
    }
}

static int userInput()  //  Метод ввода числа от пользователя.
{
    Console.WriteLine($"\nВведите число: \n");  //  Запрос ввода числа.
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0)
    {
        number *= -1;
    }
    Console.WriteLine($"\nВведенное чило: {number}\n"); //  Информационное сообщение.
    return number;
}

static int randomNumber()   //  Метод, генерирующий случайное число.
{
    int number = Convert.ToInt32(new Random().Next(1, 50)); //  Генератор случайного числа, в заданном диапазоне.
    Console.WriteLine($"\nСгенерированное число: {number}");  //  Информационное сообщение.
    return number;
}

static void outputNumbers(int number)   //  Рекурсивный метод, выводящий числа, в заданном диапазоне.
{
    if (number < 1) //  Условие выхода из рекурсии.
    {
        return;
    }
    else
    {
        Console.Write(number + " ");    //  Вывод чисел.
        outputNumbers(number - 1);  //  Вызов рекурсивного метода.
    }
}