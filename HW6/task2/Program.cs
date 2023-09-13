// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumbers(string message)
{
    Console.Write(message);
 double number = double.Parse(Console.ReadLine());
    return number;
}
double a = GetNumbers("Введите значение b1: ");
double b = GetNumbers("Введите значение k1: ");
double c = GetNumbers("Введите значение b2: ");
double d = GetNumbers("Введите значение k2: ");

double x =(c-d)/(b-a);
double y = a*x+c;
Console.WriteLine($"{x},  {y}");
