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



if ( (( num/1000)-(num%100)) == 0);


 Console.WriteLine(num + " -> да");
 

if ( (( num/1000)-(num%100)) != 0);

    
 Console.WriteLine(num + " -> нет");
    



