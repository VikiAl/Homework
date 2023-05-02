// Задача 47. Задайте двумерный массив размером m×n, 
//  случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
// int m = 3;
// int n = 4;

// double[,] array = new double[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = Math.Round (new Random().NextDouble()*10,2);
//         Console.Write(array[i,j]+"  ");
//     }
//     Console.WriteLine();
// }
// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
// int m = 4;
// int n = 5;

// int[,] array = new int[m, n];

// void FillPrintArray(int[,] array)
// {


//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-9, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите номер строки:");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца:");
// int t = Convert.ToInt32(Console.ReadLine());
// FillPrintArray(array);

// if (k - 1 > array.GetLength(0) || t - 1 > array.GetLength(1))
//     Console.WriteLine("Такой позиции нет");
// // else Console.WriteLine("На этой позиции число  " + array[k - 1, t - 1]);


// Задача 52. Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 3;

int[,] array = new int[m, n];

void FillPrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillPrintArray(array);
double sum=0;
for (int j = 0; j < array.GetLength(1); j++)
    {
                for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
            Console.Write (Math.Round(sum/n,2)+ " ");
            sum=0;
    }
