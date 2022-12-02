//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

using System;
static int  ackermannFunction(int m, int n)
{
   if(m==0)
   { 
    return n+1;
   }
   else if((n==0) && (m>0))
   {
   return ackermannFunction(m-1, 1);
   }
   else if((m > 0) && (n > 0))
   {
    return ackermannFunction(m - 1, ackermannFunction(m, n - 1));
   }
   else
   return n + 1;
}
Console.WriteLine(ackermannFunction(3, 2));