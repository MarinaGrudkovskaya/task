// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int GetRandomNumber()
// {
//     int number = new Random().Next(10, 100);
//     return number;
// }

// int GetFirstDigit(int number1)
// {
//     return number1 / 10;
// }

// int GetLastDigit(int number1)
// {
//     return number1 % 10;
// }

// void PrintNumber(int num1)
// {
//     Console.Write(num1 + " ");
// }
// void ShowLargestDigit(int digit1, int digit2)
// {
//     if (digit1 > digit2)
//     {
//         Console.Write("-> " + digit1);
//     }
//     else Console.Write("-> " + digit2);
// }

// int num = GetRandomNumber();
// PrintNumber(num);
// int firstDigit = GetFirstDigit(num);
// //PrintNumber(firstDigit);
// int lastDigit = GetLastDigit(num);
// //PrintNumber(lastDigit);
// ShowLargestDigit(firstDigit, lastDigit);

// Console.WriteLine();

// int num2 = GetRandomNumber();
// PrintNumber(num2);
// int firstDigit2 = GetFirstDigit(num2);
// int lastDigit2 = GetLastDigit(num2);
// ShowLargestDigit(firstDigit2, lastDigit2);

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

using System.ComponentModel;

int GetRandomNumber()
{
    int number = new Random().Next(100,1000);
    Console.WriteLine(number);
    return number;
}
int GetSecondNumber(int number1)
{
   
   return number1 = (number1 %100 - number1 %10) / 10;
    Console.Write(number1);
}

int number = GetRandomNumber();
int number1 = GetSecondNumber(number);
 Console.Write(number1);