// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int x = 4;
int y = 3;
int[,] array = BasisArray(x,y);
Console.Write("Введите позицию элемента в двумерном массиве обязятельно! через пробел: ");
string element = Console.ReadLine();

int[,] BasisArray(int x, int y)
{
int[,] arr = new int[x,y];
for (int i = 0; i < x; i++)
{
   for (int j = 0; j < y; j++)
   {
    arr[i,j] = new Random().Next(1,10);
    Console.Write($"{arr[i, j]}   ");
   } 
    Console.WriteLine();
}
return arr;
}

int[] GetArrayFromString(string element)
{
    string[] nums = element.Split();
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] support = GetArrayFromString(element);



if (support.Length > 2 || support[0] >= array.GetLength(0) || support[1] >=array.GetLength(1))
    Console.WriteLine("Такого элемента массива нет");
    else  
    Console.Write($"элемент: {array[support[0], support[1]]}");



