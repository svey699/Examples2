//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];
FillArrayRandomNumbers(n);
PrintArray(n);
int sum = 0;

for (int i = 0; i < n.Length; i++)
if (n[i] % 2 == 1)
sum += n[i];

Console.WriteLine($"сумма нечетных чисел = {sum}");

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