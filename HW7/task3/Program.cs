// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int row = GetNumber("Введите количество строк: ");
int column = GetNumber("Введите количество столбцов: ");
int[,] array = GetArray(row,column);
GetSumArray(array);

Console.Write(String.Join(" ", array ));

int GetNumber(string messege)
{
Console.WriteLine(messege);
return int.Parse(Console.ReadLine());
}

int[,] GetArray(int row, int column)
{
 int[,] result = new int[row, column];
 for (int i = 0; i < row; i++)
 {
    for (int j = 0; j < column; j++)
    {
        result[i,j] = new Random().Next(1,10);
         Console.Write($"{result[i, j]}  ");
    }
     Console.WriteLine();
 }
return result;
}

void GetSumArray(int[,] array)
{
double sumMedium = 0;
double[] sum = new double[row];   
 for (int i = 0; i < row; i++)
 {
    for (int j = 0; j < column; j++)
    {
        sumMedium = sumMedium + array[i,j];
        sum[i] = sumMedium/column;
     sum[i] = Math.Round(sum[i], 3);  
    
    }
     sumMedium =0;
    
    Console.Write($" {sum[i]}  ");
 }
}
            