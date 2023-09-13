// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetNums(string messege)
{
Console.WriteLine(messege);
int nam = int.Parse(Console.ReadLine());
return nam;
}
int sizeArr = GetNums("Введите длинну массива: ");
int minArr = GetNums("Введите минимальное значение массива: ");
int maxArr = GetNums("Введите максимальное значение массива: ");
int size = sizeArr;
int a = minArr;
int b = maxArr;
int[] result = new int[size];

for (int i = 0; i < size; i++)
{
    result[i] = new Random().Next(a, b);
     Console.Write($"{result[i]}  ");
    
}
 int sum = 0;
    for (int i = 1; i < result.Length; i += 2)
       { 
        sum += result[i];
       }
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {sum}");
   

 




