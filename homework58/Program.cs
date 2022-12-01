// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] hw58 (int [,] arr1,int[,]arr2)
{
   int n = arr1.GetLength(0);
   int m = arr2.GetLength(1);
   int strArr2 = arr2.GetLength(0), colsArr1= arr1.GetLength(1);
   int [,] answer = new int [n, m];
   if(strArr2 > colsArr1
   || colsArr1 > strArr2 )
   {return answer;}
      for(int i=0; i < n; i++)
   {
      for(int j=0; j < m; j++)
      {
      for(int k=0; k<strArr2; k++)
      {
         answer[i, j]+=(arr1[i, k]*arr2[k, j]);
      }
      }
   }
return answer;
}
void print (int [,]arr){

    for(int i=0;i<arr.GetLength(0);i++)
{
    for(int j=0;j<arr.GetLength(1);j++)
    {
      
    Console.Write(arr[i,j]+",");
   }
   Console.WriteLine(" ");
}
}

int[,] arr1 = new int[,]{ { 2,4 }, { 3,2 } };  
int[,] arr2 = new int[,]{ { 3,4 }, { 3,3} };  


print(hw58(arr1,arr2));