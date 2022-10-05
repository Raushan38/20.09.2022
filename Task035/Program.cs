// задача 35. задайте одномерный массив из 123 случайных чисел 
// найдите кол-во элементов массива значение которых лежат в отрезке
// [10, 99]
// [5, 18, 123, 6, 2] -> 1

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

int QuantityElemInRange (int[] array, int min, int max)
{
    int counter = default; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array [i] <= max) counter++;
    }
    return counter;

}

int[] arr = CreateArrayRndInt(10, 0, 1000);
PrintArray(arr);
int quantityElemInRange = QuantityElemInRange (arr, 10, 99);
Console.WriteLine(quantityElemInRange);