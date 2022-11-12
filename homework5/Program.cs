//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];
FillArrayRandomNumbers(n);
PrintArray(n);
int count = 0;

for (int i = 0; i < n.Length; i++)
if (n[i] % 2 == 0)
count++;

Console.WriteLine($"{count} чисел (числа, число) являются чётными");

void FillArrayRandomNumbers(int[] n)
{
    for(int i = 0; i < n.Length; i++)
    {
        n[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] n)
{
    for(int i = 0; i < n.Length; i++)
    {
        Console.Write(n[i] + ", ");
    }
    Console.WriteLine();
}