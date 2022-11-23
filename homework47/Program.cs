﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void PrintArray (double [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength (1); j++)
{
Console.Write ($"{arr [i, j]} ");
}
Console.WriteLine ();    
}
}
void FillArray (double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength (1); j++)
{
Random rnd = new Random();
arr [i, j] = Math.Round(arr[i,j] = Convert.ToDouble(rnd.Next(-10, 10)/2.0),1);
}
}
}
double [,] arr = new double [3, 4];

FillArray (arr);
Console.WriteLine();
PrintArray (arr);