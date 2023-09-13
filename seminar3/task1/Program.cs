
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int CallNumber(string message)  
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

int num = CallNumber("Введите пятизначное число: "); 
int a = num/10000;
int b = (num/1000)-a*10;
int y = (num%10);
int x = ((num%100)-y)/10;

int res1 = a-y;
int res2 = b-x;

if (res1==0 && res2==0)
 {
    Console.WriteLine(num + " -> да");
 }

else
{ 
   Console.WriteLine(num + " -> нет");
}

