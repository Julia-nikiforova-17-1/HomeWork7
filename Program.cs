﻿// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Первую размерность массив");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массив");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double [rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i,j]= new Random().Next(-10,10);
// Console.Write(matrix[i,j]+" ");
// }
// Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Первую размерность массив");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массив");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int [rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i,j]= new Random().Next(-10,10);
// Console.Write(matrix[i,j]+" ");

// }
//    Console.WriteLine();
// }

// Console.WriteLine("Введите номер строки");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите номер столбца");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a>rows && b>colomns)
// {
//     Console.WriteLine("Такого числа нет");
// }
// else 
// {
//     object c = matrix.GetValue(a,b);
//     Console.WriteLine(c);
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Первую размерность массив");
int rows = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Вторая размерность массив");
int colomns = Convert.ToInt32(Console.ReadLine());

int [,] matrix= new int [rows,colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j]= new Random().Next(-10,10);
Console.Write(matrix[i,j]+" ");

}
   Console.WriteLine();
}
for (int j = 0;j < colomns;j++)
{
    int sum=0;
    for (int i = 0; i < rows;i++)
    {
        sum=sum+ matrix[i,j];
    }
    int arif= sum/rows;
    Console.WriteLine("Среднее ариф"+"" +arif);
}
