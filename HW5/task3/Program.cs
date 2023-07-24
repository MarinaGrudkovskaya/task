// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNams(string massege)
{
  Console.WriteLine(massege);
  int num = int.Parse(Console.ReadLine());
   return num;
}
int sizeAr =GetNams("Введите длинну: ");
int minAr =GetNams("Введите минимальное число: ");
int maxAr =GetNams("Введите максимальное число: ");
double[] ar = new double[sizeAr];
for (int i = 0; i < sizeAr; i++)
{
     ar[i] = new Random().Next(minAr, maxAr);
     Console.Write($"{ar[i]}  ");
}
double min = ar[0];
double max = ar[0];

for (int i = 0; i < sizeAr; i++)
{
    if (ar[0] >= ar[i])
    min = ar[i];
}
for (int i = 0; i < sizeAr; i++)
{
     if (ar[0]<=ar[i])
    max = ar[i];

}
Console.WriteLine();
Console.WriteLine($"{max-min}");
