// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string mesege) //метод работы с пользователем
{
    Console.Write(mesege);
    int number = int.Parse(Console.ReadLine()); 
    return number;
}
int X = Promt("Введите число A: ");
int Y = Promt("Введите число В: ");
// int PoverNomber(int number) 

int sum = X;
for(int count  = 1; count<Y; count++)
{
 sum = sum*X;
}
// return sum;

Console.WriteLine(sum);
