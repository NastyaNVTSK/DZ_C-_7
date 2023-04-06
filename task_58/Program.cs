int[,] array = new int[4, 4]; 
int[,] array1 = new int[4, 4];
void FillArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] Multiplication(int[,] matrix, int[,] matrix1)
{
    int[,] multiplicated = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            multiplicated[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }
    return multiplicated;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j],3}({i}, {j})\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
FillArray(array1);
PrintArray(Multiplication(array, array1));
Console.WriteLine(); 