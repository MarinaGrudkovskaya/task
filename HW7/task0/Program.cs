// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int rows = GetNumber("введите колличество строк: ");
int columns = GetNumber("введите колличество столбцов: ");
double[,] array = GetArray(rows, columns);

int GetNumber(string messege)
{
    Console.Write(messege);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double[,] GetArray(int row, int column)
{
double[,] res = new double[row, column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        res[i,j] = new Random().NextDouble()*10-5;
        res[i,j] = Math.Round(res[i,j], 1); 
        Console.Write($"{res[i, j]}  | ");
    }
    Console.WriteLine();
}   
return res;
}
//  Console.WriteLine();
// Console.Write(array);
