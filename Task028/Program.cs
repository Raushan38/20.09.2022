﻿// задача 28. Напишите программу которая
// принимает на вход число N и выдает
// произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = DigitMultiplication(number);
    Console.WriteLine($"произведение чисел от 1 до {number} = {result}");
}
else Console.WriteLine($"введите кооректное значение");
int DigitMultiplication(int num)
{
    int multiplic = 1;
    for (int i = 1; i <= num; i++)
    {
        multiplic = multiplic * i;
    }
    return multiplic;
}