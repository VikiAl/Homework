// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int []array =new int [10];
// int count =0;

// for (int i=0; i<array.Length; i++)

//  { 
//     array[i] = new Random().Next(100,1000);
//      if (array[i]%2==0)
//     {
//       count++;
//     }
      
//  }
//  Console.WriteLine (String.Join(",",array));
//  Console.WriteLine (count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] array = new int [8];
// int sum=0;
// for (int i=0; i< array.Length; i++)
// {
//     array[i]= new Random().Next(-10,11);
//     if (i%2!=0)
//     {
//         sum=sum+array[i];
//     }
// }
// Console.WriteLine(String.Join(",", array));
// Console.WriteLine (sum);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 

int []array = new int[]{-4,6,-1,9,-3};
Console.WriteLine(String.Join(",",array));
int max =0;
int min=array[0];
for (int i=0; i<array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    else if (array[i]<min)
    {
        min=array[i];
    }
}
int sum = max+min;
Console.WriteLine(sum);