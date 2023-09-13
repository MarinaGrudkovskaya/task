// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
int row = 4;
int colom = 3;
int[,] array = GetArray(row, colom);
//  Console.Write(GetSum); - так вызывать не нужно, Вызываем как указанно ниже
 Console.Write($" Искомая строка -> {GetSum(array)}");    

int[,] GetArray(int row, int colom)
{
    int[,] array = new int[row, colom];
    for (int i = 0; i < row; i++)
    {
       for (int j = 0; j < colom; j++)
       {
        array[i, j] = new Random().Next(0,5);
        Console.Write($"{array[i, j]}  | ");
       } 
       Console.WriteLine();
    }
    return array;
}

 int GetSum(int[,] array)
 {
  int row = 0;
  int sumMin = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    sumMin = sumMin + array[0,j];
  }
  for (int i = 0; i < array.GetLength(0); i++)
  {
     int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    if (sumMin > sum)
    {
      sumMin = sum;
      row = i;
    }
  }
  return row +1;
 }
