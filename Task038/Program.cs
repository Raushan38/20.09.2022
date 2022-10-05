// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

/// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
      

int[] arr = CreateArrayRndInt(4, -10, 100);
PrintArray(arr);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        {
            max = arr[i];
        }
    if (arr[i] < min)
        {
            min = arr[i];
        }
}

Console.WriteLine($" Разница между мак и мин значением = {max - min}");