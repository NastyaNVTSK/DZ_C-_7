Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,cols];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}
FillArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t|");
        Console.WriteLine();
    }
}
PrintArray(array);

int Sum(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int min = 1;
int sum = Sum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
if (sum > Sum(array, i))
{
sum = Sum(array, i);
min = i+1;
}
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {min}");








