//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void PrintArray (int [,] arr)
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
void FillArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
   {
    for (int j = 0; j < arr.GetLength (1); j++)
{
arr [i, j] = new Random().Next (1, 10);
}
}
}
int [,] arr = new int [3, 4];
FillArray (arr);
Console.WriteLine();
PrintArray (arr);
System.Console.Write("Введите номер строки ");
int Nstring = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите номер столбца ");
int Ncolumn = Convert.ToInt32(Console.ReadLine());
if (Nstring>3 && Ncolumn>4)
 Console.WriteLine("такого числа в массиве нет");
 else
 {
 object Num = arr.GetValue (Nstring, Ncolumn);
 Console.WriteLine($"Значение = {Num}");
 }