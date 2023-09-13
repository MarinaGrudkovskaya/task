// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int sizeArray = GetNum("Введите длину массива: ");
int min = GetNum("Введите минимальное значение диапазона для элементов массива: ");
int max = GetNum("Введите максимальное значение диапазона для элементов массива: ");
int[] array = GetArray(sizeArray, min, max);
PrintArray(array);


int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
void PrintArray(int[] arr)
{
    foreach (var el in arr)
    {
        int arr = -arr;
    }
 
}
int[] GetSums(int[] arr);

// {
//     int[] res = new int[2]; // [0,0]
//     foreach (int el in arr)
//     {
//         if (el > 0) res[0] = res[0] + el;
//         if (el < 0) res[1] += el;
//     }
//     return res;
// }