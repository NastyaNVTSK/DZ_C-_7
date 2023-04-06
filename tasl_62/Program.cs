int n = 5;
int[,] array = new int[n, n];

int tmp = 1;
int i = 0;
int j = 0;

while (tmp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = tmp;
  tmp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t|");
        Console.WriteLine();
    }
}