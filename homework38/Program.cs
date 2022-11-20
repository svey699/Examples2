//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Количество чисел: ");
int nums = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[nums];
int max = 0;
int min = 0;
 
Console.WriteLine();  
for (int i = 0; i < nums; i++)
{
      Console.Write("Введите число {0}: ", i + 1);
      arr[i] = Convert.ToInt32(Console.ReadLine());
}
min = arr[0];
max = arr[0];
for (int i = 1; i < nums; i++)
{
       if (arr[i] < min)
            min = arr[i];
       if (arr[i] > max)
            max = arr[i];
}
Console.WriteLine(); 
Console.WriteLine("Минимальное значение = " + arr.Min());
Console.WriteLine("Максимальное значение =" + arr.Max());
Console.WriteLine($"разница = {arr.Max() - arr.Min()}");