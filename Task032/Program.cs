﻿// задача 32. напишите программу замена элементов массива:
// положительные элементы заменить на соответсвующие
// отрицательные б и наоборот

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] InversionNum(int[] array) // условие задачи 32
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
} // конец уловия

int[] arr = CreateArrayRndInt(4, -8, 8);
PrintArray(arr);
InversionNum(arr);
PrintArray(arr);
