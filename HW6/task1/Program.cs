
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// string[] input = Console.ReadLine()!.Split(' ');



int[] Input(string abc)     // Записываем массив из строки, преобразуем строковой массив 
                                  // в числовой На вход принимаем сообщение для пользователя
{
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(" ");
    int[] numbers = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
        numbers[i] = int.Parse((input[i]));
    return numbers;
}
int[] array = Input("Введите числа через пробел: ");
int nam = 0;
foreach (int el in array) 
{
    if (el>0)
    nam = nam + 1;
}

Console.WriteLine($"положительных чисел:{nam}");
// // мой метод - вопрос к пользователю:
// string GetNumbers(int count, string message)  
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + message;
//     }
//     return result;
// }
// string a = GetNumbers(1, "Введите 5 чисел");
// Console.WriteLine(a);
// // мой метод - вопрос к пользователю:

 // Console.WriteLine(message);
    // string[] array = Console.ReadLine().Split(" ");

