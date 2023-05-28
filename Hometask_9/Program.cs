// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int N = ReadInt("Введтите число N: ");
// Numbers(N);
// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void Numbers(int N)
// {
//     if (N < 1) return;
//     Console.Write(N + " ");
//     Numbers(N - 1);
// }

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int M = ReadInt("Введите натуральное число M ");
// int N = ReadInt("Введите натуральное число N ");
// if (N < M) Console.Write("Не верные значения");
// else System.Console.WriteLine("Сумма чисел от M до N равна  " + Sum(M,N));

// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());

// }

// int Sum(int a, int b)
// {
//     if (a > b) return 0;
//     return b + Sum(a, b - 1);
// }

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = ReadInt("Введите натуральное число m ");
int n = ReadInt("Введите натуральное число n ");
if (m<0 && n<0)  Console.WriteLine("Значение чисел должны быть больше нуля");
else Console.WriteLine("Значение функции Акермана равно " +Akerman(m, n));

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int Akerman(int a, int b)
{
    if (a == 0) return b + 1;
    else
     if ((a> 0) && (b == 0)) return Akerman(a - 1, 1);
    else
     return Akerman(a - 1, Akerman(a, b - 1));
}