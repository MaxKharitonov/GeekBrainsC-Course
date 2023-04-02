﻿// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] array = new int[4, 4];   //  Инициализация массива.
int number = 1;                 //  Инициализация переменной, в которой храниться
                                //  значение элемента, который будет записан в массив.
int rowStart = 0;               //  Инициализация переменной, в которой храниться 
                                //  начальный индекс строки массива.
int rowEnd = 3;                 //  Инициализация переменной, в которой храниться 
                                //  конечный индекс строки массива.
int colStart = 0;               //  Инициализация переменной, в которой храниться
                                //  начальный индекс столбца массива.
int colEnd = 3;                 //  Инициализация переменной, в которой храниться
                                //  конечный индекс столбца массива.
while (rowStart <= rowEnd && colStart <= colEnd)    //  Инициализация цикла,
                                                    //  заполняющего массив
                                                    //  по спирали.
{
    for (int i = colStart; i <= colEnd; i++) //  Цикл, заполняющий первую строку
                                             //  массива.
    {
        array[rowStart, i] = number++;    // Заполнение первой строки массива.
    }
    rowStart++; //  Смена начального индекса строки массива.

    for (int i = rowStart; i <= rowEnd; i++) //  Цикл, заполняющий правый столбец
                                             //  массива.
    {
        array[i, colEnd] = number++;  //  Заполнение правого столбца массива.
    }
    colEnd--;   //  Смена конечного индекса столбца массива.

    for (int i = colEnd; i >= colStart; i--) //  Цикл, заполняющий нижнюю 
                                             //  строку массива.
    {
        array[rowEnd, i] = number++;  //  Заполнение нижней строки массива.
    }
    rowEnd--;   //  Смена конечного индекса строки массива.

    for (int i = rowEnd; i >= rowStart; i--) // Цикл, заполняющий левый
                                             // столбец массива.
    {
        array[i, colStart] = number++;    // Заполнение левого столбца массива.
    }
    colStart++; //  Смена начального индекса столбца массива.
}
PrintArray print = new PrintArray();
print.PrintTwoDimArray(array);