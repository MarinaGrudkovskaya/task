﻿// Домашка по второму семинару:

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Введите трухзначное число:");
// int n = int.Parse(Console.ReadLine());
// int nam = n%10;
// int nam1 = n%100;
// int rezult = (nam1-nam)/10;
// Console.Write( "-> " + rezult);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число:");
// int a = int.Parse(Console.ReadLine()!);
//    if (a<100)
//    {
//     Console.WriteLine(a + "->третьей цифры нет");
//    }
//    if (a>99 && a<1000)
//    {
//     int a1 = a%10;
//     Console.WriteLine(a + "-> " + a1);
//    }
// if (a>999 && a<10000)
//    {
//     int a2 = (a%100-a%10)/10;
//     Console.WriteLine(a + "-> " + a2);
//    }
// if (a>9999 && a<100000)
//    {
//     int a3 = (a%1000-a%100)/100;
//     Console.WriteLine(a + "-> " + a3);
//    }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Ввудите цифру от 1 до 7:");
int d = int.Parse(Console.ReadLine()!);
if (d<=5)
{

  Console.WriteLine(d + " -> нет");
}
else
{
   Console.WriteLine(d + " -> да");
}