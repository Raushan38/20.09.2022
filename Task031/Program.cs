// задача 31. задайте массив из 12 элементов  
// заполненный случайнными числами из промежутка
// (-9, 9). найдите сумму отрицательных и положительных
// элементов массива

// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел = 29
// сумма отрицательных чисел = -20

int[] CreateArrayRndInt(int size, int min, int max) // создать массив начало
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
} // конец

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNegative += array[i]; // sumNegative = sumNegative + array[i]
        else sumPositive += array[i];
    }

    return new int[] { sumPositive, sumNegative };

}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositiveNegativeElem[1]}");
