﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

 // int.Parse -помогает переводить строку в число

// Console.WriteLine("Введите число: "); // подсказка для пользователя
// int number = int.Parse(Console.ReadLine());  // команда "Console.ReadLine()" считывание с консоли
// int result = number * number; // результирующая переменная, храним резкльтет вычисления
// Console.WriteLine("Квадрат числа = " + result);  // конкатенация, склеивание строки через +

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли
// первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// Console.WriteLine("Введите числа:");  // подсказка для пользователя
// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());
// if (number1 == number2 * number2)
// {
//   Console.WriteLine("первое число - квадрат второго");  
// }
// else
// {
//   Console.WriteLine("первое число - не квадрат второго");  
// }

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите число:");
// int number1 = int.Parse(Console.ReadLine());
// if (number1 == 1)
// {
//  Console.WriteLine("понедельник");  
//  }
//  if (number1 == 2)
// {
//  Console.WriteLine("вторник");  
//  }
//  else
//  {
//   Console.WriteLine("число не соответствует дню недели");  
//  }


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите числa:");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1<number2)
{
    Console.WriteLine("max - число1");
}
else
{
    Console.WriteLine("max - число2");
}


