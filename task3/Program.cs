// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string  message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int x = Prompt("Введите точку x: ");
int y = Prompt("Введите точку y: ");
GetResult(x,y);

void GetResult(int X, int Y)
{
if(x>0 && y>0)
{
    Console.WriteLine("I четверть");
}
if(x<0 && y>0)
{
    Console.WriteLine("II четверть");
}
if(x<0 && y<0)
{
    Console.WriteLine("III четверть");
}
if(x>0 && y<0)
{
    Console.WriteLine("VI четверть");
}
}