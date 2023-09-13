// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2       7 4 2 1
// 5 9 2 3       9 5 3 2
// 8 4 2 4       8 4 4 2

int[,]arr = new int[3,3];
GetArray(arr);
PrintArray(arr);

Console.WriteLine();

GetNewArray(arr);
PrintArray(arr);

void GetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
     {
        for (int j = 0; j < arr.GetLength(1); j++)
      {
        arr[i,j] = new Random().Next(1,10);
      }
     }
}

void GetNewArray(int[,] arr)
{

for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int n = 0; n < arr.GetLength(1)-1; n++)
    {
     if (arr[i, n] < arr[i, n+1])
     {
      int newArr = arr[i, n + 1];
       arr[i, n+1] = arr[i, n];
       arr[i ,n] = newArr;
     }
    }
  }
}
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        Console.Write(arr[i,j] + "|");
      } 
     Console.WriteLine();
    }
    
}

