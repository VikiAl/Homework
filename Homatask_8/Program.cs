// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows, columns];
// void FillArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
//     Console.WriteLine();
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }
// void Bublesort()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(1) - 1 - j; k++) 
//             // для сортировки вводим доп переменную, которая поможет пробегаться по строке 
//             //несколько раз, и с каждым разом не трогая последний элемент от предыдущего круга
//             // т.к. он уже и так самый маленький
//             {
//                 if (result[i, k + 1] > result[i, k])
//                 {
//                     int temp = result[i, k];
//                     result[i, k] = result[i, k + 1];
//                     result[i, k + 1] = temp;

//                 }
//             }
//         }

//     }
//     Console.WriteLine();
// }
// FillArray();
// PrintArray(result);
// Bublesort();
// PrintArray(result);

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка
// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] result = new int[rows, columns];
// FillArray();
// PrintArray(result);
// RowSumMin();
// void FillArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
//     Console.WriteLine();
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }
// void RowSumMin()
// {
//     int sum= 0;
//     int min=int.MaxValue;
//     int line=0;
//    for (int i = 0; i < result.GetLength(0); i++)
//     {

//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             sum= sum+result[i,j];
//         }
//         if (sum<min)
//         {
//             min=sum;
//             line=i+1;
//         }
//         sum=0;
//     }
//        Console.WriteLine("Строка с наименьшей суммой элементов " +line);
// }

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows1 = ReadInt("Введите число строк Матрицы 1: ");
int columns1 = ReadInt("Введите число столбцов Матрицы 1: ");
int rows2 = ReadInt("Введите число строк Матрицы 2: ");
int columns2 = ReadInt("Введите число столбцов Матрицы 2: ");

int[,] matrix1 = new int[rows1, columns1];
int[,] matrix2 = new int[rows2, columns2];

FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
PrintArray(matrix2);
MatrixMultiplication(matrix1, matrix2);

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    Console.WriteLine();
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (columns1 != rows2) Console.WriteLine("Умножение матриц не возможно");
    else
    {
        int[,] matrixC = new int[rows1, columns2];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < matrixA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write(matrixC[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

