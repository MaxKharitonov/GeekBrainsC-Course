﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) // Проверка: является ли введенное число трехзначным.
{
    Console.WriteLine("Ошибка! Введенное число не трехзначное!");
    return; // Если введенное число не трехзначное, вывод ошибки и завершение программы.
}

// Console.WriteLine($"Первая цифра числа: {number / 100}"); // Получаем первую цифру числа 
Console.WriteLine($"Вторая цифра числа: {number % 100 / 10}"); // Получаем вторую цифру числа 
// Console.WriteLine($"Третья цифра числа: {number % 10}"); // Получаем третью цифру числа


/*
************************************Задачи семинара:************************************

 *********************************Задача №11 мое решение:********************************

                    int randomNumber = new Random().Next(100, 1000);
                    int firstNumber = randomNumber / 100 * 10;
                    int lastNumber = randomNumber % 10;
                    // int fNumber = firstNumber * 10;
                    int newNumber = firstNumber + lastNumber;
                    Console.WriteLine($"Случайное число: {randomNumber}");
                    Console.WriteLine($"Новое число: {newNumber}");

****************************************************************************************

*********************************Задача №12 мое решение:********************************

                    Console.WriteLine("Введите первое число: ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());
                    if (firstNumber % secondNumber == 0)
                    {
                    Console.WriteLine($"Число {firstNumber} кратно числу {secondNumber}.");
                    }
                    else
                    {
                    int remainder = firstNumber % secondNumber;
                    Console.WriteLine($"Число {firstNumber} не кратно числу {secondNumber}, остаток {remainder}.");
                    }

****************************************************************************************

*********************************Задача №14 мое решение:********************************
                
                    Console.WriteLine("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number % 7 == 0 && number % 23 == 0)
                    {
                        Console.WriteLine($"Число {number} кратно числу 7 и числу 23.");
                    }
                    else if (number % 7 == 0 && number % 23 != 0)
                    {
                        Console.WriteLine($"Число {number} кратно числу 7, но не кратно числу 23.");
                    }
                    else if (number % 23 == 0 && number % 7 != 0)
                    {
                        Console.WriteLine($"Число {number} кратно числу 23, но не кратно числу 7.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} не кратно числу 7 и числу 23.");
                    }

****************************************************************************************

*********************************Задача №16 мое решение:********************************

                    Console.WriteLine("Введите первое число: ");
                    int fNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    int sNumber = Convert.ToInt32(Console.ReadLine());
                    if (fNumber * fNumber == sNumber)
                    {
                    Console.WriteLine($"Число {fNumber} является квадратом числа {sNumber}.");
                    }
                    else if (sNumber * sNumber == fNumber)
                    {
                    Console.WriteLine($"Число {sNumber} является квадратом числа {fNumber}.");
                    }
                    else
                    {
                    Console.WriteLine($"Числа {fNumber} и {sNumber} не являются квадратами друг друга.");
                    }

****************************************************************************************

************************************Заметки из семинара:***********************************

                                            ***
                        Вывод случайного числа в заданном диапазоне

        Чтобы получить случайное число, используется класс - "Random"
                /// *** new - выделяет память под экземпляр используемого класса
        Чтобы задать диапазон, из которого нужно получить число, используется метод - "Next"
        Объявим переменную, в которую, передадим случайное число и зададим диапазон:

            *** int number = new Random().Next();

        В параметры метода "Next", передаем диапазон случайных чисел:

            *** int number = new Random().Next(10, 100);

        !!!-ВАЖНО - !!!-ПЕРВЫЙ ПАРАМЕТР ВКЛЮЧАЕТСЯ В ДИАПАЗОН, ВТОРОЙ НЕ ВКЛЮЧАЕТСЯ - !!!

        Первый параметр устанавливает начало диапазона: 10(Число 10 ВКЛЮЧЕНО в диапазон)
        Второй, его конец: 100, (Число 100 НЕ ВКЛЮЧЕНО в диапазон, но необходимое значение 99 ВКЛЮЧЕНО в диапазон)

                                            ***
                    Получение первой и последней цифры из двузначного числа:

        Инициализируем переменную, в которой будет содержаться двузначное число:

            *** int number = 42;

        Для получения последней цифры, нициализируем переменную, в которую передадим, остаток от деления на 10 заданного числа:

            *** int digit2 = number % 10;

                *** \\\ Получим остаток: "2", который и является последней цифрой, заданного числа *** /// 

        Для получения первой, инициализируем переменную, в которую передадим, результат деления на 10 заданного числа, без остатка:

            *** int digit1 = number / 10;

                *** \\\ Получим результат равный "4", который является первой цифрой, заданного числа *** ///

                                            ***
                *** \\\ Небольшое упрощение вывода через консколь /// ***

                *** \\\ Например, чтобы упростить запись вида:  /// ***
                    
                    *** \\\ *** Console.WriteLine("Случайное число: " + number + " Первая цифра: " + digit1 + " Вторая цифра: " + digit2); /// ***
        
                *** \\\ Используем специальные операторы: /// ***
            
                *** \\\ -"$" - включает расширенные возможности, для форматирования, строки вывода /// ***
                *** \\\ - "{ }" - служат для указания мест, где будут находиться, значения переменных  /// ***
                
                *** \\\ Получим следующий результат: /// ***
                
                    *** \\\ *** Console.WriteLine($"Случайное число: {number},  Первая цифра: {digit1},  Вторая цифра: {digit2}"); /// ***
        
                *** \\\ Вывод стал проще и понятнее, без использования лишних символов /// 
*/
