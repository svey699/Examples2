//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
  
 double [] arr(int [,] nums)
        {
int str = nums.GetLength(0);
int cols = nums.GetLength(1);
int sum = 0;
double [] average = new double[cols];
    for(int i = 0; i < cols; i++)
   {
    for(int j = 0; j < str; j++)
   {
sum+=nums[j, i];
    }
    average [i] = Math.Round((double)sum/str, 1);
sum=0;
    }
return average;

}
void printArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
Console.Write(arr[i] + "   ");
            }
}
void print (int [,]arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
Console.Write(arr[i,j] + ",");
    }
Console.WriteLine(" ");
    }
}

int[,] arr1 = new int[,]{ {1, 4, 7, 2}, {5, 9, 2, 3},{8, 4, 2, 4}};

print(arr1);
Console.WriteLine( );
Console.WriteLine("Среднее значение каждого столбца = ");
printArr(arr(arr1));