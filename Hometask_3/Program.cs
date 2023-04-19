// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine ("Введите пятизначное число");
// int num  =Convert.ToInt32(Console.ReadLine());
// int x1 = num/10000;
// int x2 = (num%10000)/1000;
// int x4 = (num%100)/10;
// int x5 = num%10;
// if (x1==x5 && x2==x4)
// {
//   Console.WriteLine ("Число является палиндромом");
// }
// else
// {
//    Console.WriteLine ("Число не является палиндромом");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите число X1:");
// int X1  =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число X2:");
// int X2  =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Y1:");
// int Y1  =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Y2:");
// int Y2  =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Z1:");
// int Z1  =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Z2:");
// int Z2  =Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
// d=Math.Round(d,2);
// Console.WriteLine(d);

// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число :");
int num  =Convert.ToInt32(Console.ReadLine());

for (int temp =1;temp <= num; temp++)
{
        Console.WriteLine(Math.Pow(temp,3));
}



