// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int PointCoordinat(string  message)     
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int x1 = PointCoordinat("Введите точку x1: ");
int y1 = PointCoordinat("Введите точку y1: ");
int z1 = PointCoordinat("Введите точку z1: ");
int x2 = PointCoordinat("Введите точку x2: ");
int y2 = PointCoordinat("Введите точку y2: ");
int z2 = PointCoordinat("Введите точку z2: ");


double xyz = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
 Console.WriteLine(Math.Round(xyz, 2));





// GetSquare();

// void GetSquare()
// {
//         Console.Write("x1 - ");
//         int x1 = int.Parse(Console.ReadLine());

//         Console.Write("y1 - ");
//         int y1 = int.Parse(Console.ReadLine());

//         Console.Write("x2 - ");
//         int x2 = int.Parse(Console.ReadLine());

//         Console.Write("y2 - ");
//         int y2 = int.Parse(Console.ReadLine());

//         double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

//         Console.WriteLine(Math.Round(a,2));
// }
// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125