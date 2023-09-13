// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int row = 2;
int colom =2;
int[,] arr1 = GetArray(row, colom);
PrintArray(arr1);
Console.WriteLine();
int[,] arr2 = GetArray(row, colom);
PrintArray(arr2);
int[,] matrix = MultMatrix( arr1, arr2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");
PrintArray(matrix);





int[,] GetArray(int row, int colom)
{
    int[,] array = new int[row, colom];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colom; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

int[,] MultMatrix(int[,]arr1, int[,]arr2)
{
    int row = arr1.GetLength(0);
    int colom = arr2.GetLength(1);
    int[,] matrix = new int[row, colom];
 for (int i = 0; i < row; i++)
 {
    for (int j = 0; j < colom; j++)
    {
        for (int n = 0; n < arr1.GetLength(1); n++)
        {
            matrix[i,j] += arr1[i, n]*arr2[n, j];
        }
    }
 }
  return  matrix;
}


