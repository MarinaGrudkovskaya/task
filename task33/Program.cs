
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
int num = Prompt("Введите чиcло:  ");
void CubeNumber(int num)
{
    int count = 1; 
    while (count <= num)
    {
        if (count == num)
        {
          Console.WriteLine(count*count*count);   
        }
        else
        Console.Write(count*count*count + "," );
     count ++;
    }
    
}
Console.Write($"{num} -> ");
 CubeNumber(num);