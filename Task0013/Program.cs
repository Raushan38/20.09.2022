// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = number % 10;
if (number > 99) Console.WriteLine($"третья цифра заданного числа {number} = {thirdDigit}");
else Console.WriteLine($"третьей цифры нет");
