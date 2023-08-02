﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int n = 8;
string NamberRecur(int n)
{
if(n>0) return  $"{n}, " + NamberRecur(n-1);
else return string.Empty;
}
Console.Write($"{n} -> ");
Console.WriteLine(NamberRecur(n));