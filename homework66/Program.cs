//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;

int  arr(int n, int m)
{
    int sum=0;
    for(int i=n; i<=m; i++)
    {
        sum+=i;
    }
    return sum;
}
int recursiveArr (int n, int m)
{
if(n==m)
return m;
else
return n+recursiveArr(n+1, m);
}
Console.WriteLine(arr(1, 15));
Console.WriteLine(recursiveArr(4, 8));