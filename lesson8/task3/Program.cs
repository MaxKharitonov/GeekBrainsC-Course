// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int rows = new Random().Next(3, 7); //  Инициализация переменной, хранящей длину строки массива.
int cols = rows;                    //  Инициализация переменной, хранящей длину столбца массива.

Matrix matrix1 = new Matrix(Matrix.getRandomMatrix(rows, cols));
matrix1.Print();
Matrix matrix2 = new Matrix(Matrix.getRandomMatrix(rows, cols));
matrix2.Print();
Matrix result = matrix1 * matrix2;

result.Print();