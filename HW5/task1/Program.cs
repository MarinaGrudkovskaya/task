// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int MaxValue)  //создаем массив
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
    result[i] = new Random().Next(100, 1000);
    Console.Write($"{result[i]}  ");
}
    return result;
}
int[] array = GetArray(10, 100, 1000);



 int count = 0;
for (int i = 0; i < 10; i++)
{
  if (array[i]%2==0)
{
count=count+1;
}
}
  Console.WriteLine();
  Console.WriteLine($" количество чётных чисел в массиве: {count}"); 


 


  


