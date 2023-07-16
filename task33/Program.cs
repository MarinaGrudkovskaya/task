// ﻿// Задача 22: Напишите программу, которая
// // принимает на вход число (N) и выдаёт таблицу
// // квадратов чисел от 1 до N.
// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

// int GetNumber(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе из функции выдаем это число
// {
//     Console.Write(message + " ");
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// void Square(int num) //Печатаем последовательно квадраты числа от 1 до n
// {
//     int count = 1;
//     while (count <= num)
//     {
//         if (count == num)
//             Console.Write(count * count);
//         else
//             Console.Write(count * count + ", ");
//         count++;
//     }
// }

// int n = GetNumber("Введите число:"); //запрашиваем переменную n у пользователя через функцию GetNumber
// Square(n); //Запускаем функцию печати квадратов

// // Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
Console.Clear();
Console.Write(message);
int number = int.Parse(Console.ReadLine());
return number;
}
int num = Prompt("Введите чило:  ");
void CubeNumber(int num)
{
    int count = 1  
    while (count <= num)
    {
        if (count = num)
        {
            
        }
    Console.WriteLine(num)
    }

}
