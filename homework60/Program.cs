//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int [,,] createArr ()
{
  int block = 2;
  int str = 2;
  int row = 2;
  int [,,] arr = new int [block, str,row];
  Random rnd = new Random();

for(int i = 0; i < block; i++)
{
  for(int j = 0; j < str; j++)
  {
    for(int k = 0; k < row; k++)
    {
     arr[i, j, k] = rnd.Next(10,100);
    }
  }
}
return arr;
}

void arr(int [,,] arr)
{
for(int i = 0; i < arr.GetLength(0); i++)
{
  for(int j = 0; j < arr.GetLength(1); j++)
  {
  for(int k = 0; k < arr.GetLength(2); k++)
    {
     Console.Write("( "+i+", "+j+" ,"+k+") "+arr[i, j, k]);
    }
  }
  Console.WriteLine();
}

}

int[, ,] arr3d2 = new int[2, 2, 2]
{
                { {60, 25}, {34, 41} },
                { {27, 90}, {26, 55} }
            };
arr(arr3d2);

Console.WriteLine();
arr(createArr());
