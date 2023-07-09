// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
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

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);

if (a>=10 & a<100)
 {
    Console.WriteLine("Третьей цифры нет(");
 }
if (a>=100)
{
  int nam=(a%100-a%1000)/100;
    Console.WriteLine(-nam);
}