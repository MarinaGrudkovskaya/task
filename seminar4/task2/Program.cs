// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string mesege)
{
    Console.WriteLine(mesege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int X = Promt("Введите число: ");
int a = 0;

if (X>0 && X<10)
{
  Console.WriteLine("Сумма чисел в числе - " + X);  
}
if (X>9 && X<100)
{
    a = (a+X/10)+(X%10);  
  
   Console.WriteLine("Сумма чисел в числе - " + a);  
}
if (X>99 && X<1000)
{
  a = (a+X/100)+((X/10)%10)+(X%10); 
   Console.WriteLine("Сумма чисел в числе - " + a);     
}
if (X>999 && X<10000)
{
  a =(a+X/1000)+((X/100)%10)+((X/10)%10)+(X%10);
   Console.WriteLine("Сумма чисел в числе - " + a);     
}



