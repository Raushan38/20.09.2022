// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number % 100;
int secondDigit = firstDigit / 10;
Console.WriteLine($"вторая цифра числа {number} = {secondDigit}");
