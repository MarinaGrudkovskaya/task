﻿
// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int GetNumber(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine());
}

void GetSumNumber(int a);
int sum = 0;
for (int i = 1; i <=A; i++)
{
     sum += i;
}
Console.WriteLine($"Сумма чисел щт 1 до {a} = {sum}");
int A = GetNumber("Введите число: ");
GetSumNumber(A);