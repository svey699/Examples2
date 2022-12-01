﻿//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int arr (int [,]nums)
{
int minsum = 100000;
int sum = 0;
int row = 0;
    for(int i=0; i < nums.GetLength(0); i++)
{
    for(int j=0; j<nums.GetLength(1);j++){
    sum+=nums[i,j];
}
if(sum<minsum)
{
    minsum = sum;
    row = i + 1;
}
sum = 0;
}
return row;
}
 var myArray = new int[4, 4]
        {
            {1 ,4 ,7, 2},
            {5, 9, 2, 3},
            {8, 4, 2 ,4},
            {5, 2, 6, 7}
        };
Console.Write($"Строка с наименьшей суммой: {arr(myArray)}");