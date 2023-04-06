int[,,] array = new int[2, 2, 2]; 
int[] nums = new int[6];
bool Exists(int number)
{
    foreach (int num in nums)
    {
        if (num == number)
        {
            return true;
        }
    }
    return false;
}
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = new Random().Next(1, 50); 
                while (Exists(number))
                {
                    number = new Random().Next(1, 50);
                }
                array[i, j, k] = number;
                nums[i + j + k] = number;
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],3}({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}
FillArray(array);
PrintArray(array); 
Console.WriteLine();
