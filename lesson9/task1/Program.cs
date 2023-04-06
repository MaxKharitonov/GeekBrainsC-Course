// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

selectOption(menu());   //  Запуск программы.

static int menu()   //  Метод, выводящий меню в консоль.
{
    Console.WriteLine($"Ввести или сгенерировать число?");  //  Пункты меню.
    Console.WriteLine();
    Console.WriteLine($"1 - Ввести");
    Console.WriteLine($"2 - Сгенерировать");
    Console.WriteLine($"0 - Выход");
    Console.WriteLine();
    int key = Convert.ToInt32(Console.ReadLine());  //  Запрос ввода от пользователя.
    return key;
}

static void selectOption(int key)   //  Метод, обрабатывающий ввод от пользователя.
{
    Console.WriteLine();
    Console.WriteLine($"Ввeдена команда: {key}");   //  Информационное сообщение.
    Console.WriteLine();
    int number; //  Объявление переменной, в которую будет записано число.
    while (true)    //  Запуск бесконечного цикла.
    {   //  Можно расписать через while != 0, чтобы запускать программу, пока не будет введен 0.
        if (key == 1)   //  Введена команда 1.
        {
            number = userInput();   //  Вызов метода ввода числа от пользователя.
            Console.WriteLine($"Натуральные числа от {number} до 1: "); //  Вывод результата.
            Console.WriteLine();
            outputNumbers(number);  //  Вызов метода рекурсивного, находящего числа, в заданном диапазоне.
            Console.WriteLine();
            Console.WriteLine();
            break;  //  Завершение программы.
        }
        else if (key == 2)  //  Введена команда 2.
        {
            number = randomNumber();    // Вызов метода, генерирующиего случайное число.
            Console.WriteLine($"Натуральные числа от {number} до 1: "); //  Вывод результата.
            Console.WriteLine();
            outputNumbers(number);  //  Вызов рекурсивного метода, находящего числа, в заданном диапазоне.
            Console.WriteLine();
            Console.WriteLine();
            break;  //  Завершение программы.
        }
        else if (key == 0)  //  Введена команда 0.
        {
            Console.WriteLine($"Заершение программы..");    // Информационное сообщение.
            Console.WriteLine();
            break;  //  Завершение программы.
        }
        else    //  Ввод неизвестной команды.
        {
            Console.WriteLine($"Ошибка! Введена неизвестная команда!"); //  Вывод ошибки.
            Console.WriteLine();
            break;
        }
    }
}

static int userInput()  //  Метод ввода числа от пользователя.
{
    Console.WriteLine($"Введите число: ");  //  Запрос ввода числа.
    int number = Convert.ToInt32(Console.ReadLine());
    if (isPositive(number) == false)    //  Проверка, введенного числа на отрицательное значение.
    {
        Console.WriteLine();
        Console.WriteLine($"Ошибка! Введенное число меньше 0!");
        Console.WriteLine($"Получение положительного числа!");
        Console.WriteLine();
        Console.WriteLine($"Новое число: {number * -1}");   //  Получение положительного числа.
        Console.WriteLine();
        return number * -1;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Введенное чило: {number}"); //  Информационное сообщение.
        Console.WriteLine();
        return number;
    }
}

static bool isPositive(int number)  //  Метод, проверяющий введенное число на отрицательное значение.
{
    if (number < 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

static int randomNumber()   //  Метод, генерирующий случайное число.
{
    int number = Convert.ToInt32(new Random().Next(1, 50)); //  Генератор случайного числа, в заданном диапазоне.
    Console.WriteLine($"Сгенерированное число: {number}");  //  Информационное сообщение.
    Console.WriteLine();
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