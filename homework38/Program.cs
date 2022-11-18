//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] arr = {3, 7, 22, 2, 78};
Console.WriteLine("min = " + arr.Min());
Console.WriteLine("max =" + arr.Max());
Console.WriteLine($"разница = {arr.Max() - arr.Min()}");
