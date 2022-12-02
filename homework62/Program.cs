

void arr ()
{
int [,] nums = new int [4, 4];
int rows = nums.GetLength(0);
int cols = nums.GetLength(1);
int num = 1;
int left = 0, right = cols-1, top = 0, bottom = rows-1;
int dir = 1;

//перемещает справа на лево
while(top <= bottom && left <= right)
{
if(dir==1)
{
for(int i = right; i >= left; i--)
{
nums[top, i] = num;
num++;
}
++top;
dir=2;
}
else if(dir==2) 
{
   for(int i=top; i <=bottom; i++)
   {
      nums[i, left] = num;
      num++;
   }
   left++;
   dir=3;
}
else if(dir ==3) //слева на право
{
   for(int i = left; i <=right; i++)
   {
      nums[bottom, i] = num;
      num++;
   }
   bottom--;
   dir=4;
}
else if(dir == 4)
{
   for(int i = bottom; i >= top; i--)
   {
      nums[i, right] = num;
      num++;
   }
   right--;
   dir=1;
}
}

for(int i = 0; i < nums.GetLength(0); i++)
{
   for(int j = 0; j < nums.GetLength(1); j++)
{
   Console.Write(nums[i, j]+ ", ");
   }
   Console.WriteLine(" ");
}
}

arr();