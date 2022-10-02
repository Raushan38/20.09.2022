// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число 
// A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("введите число A");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int num2 = Convert.ToInt32(Console.ReadLine());
int degree = num1;

for (int i = 1; i < num2; i++)
{
degree = degree * num1;
}
Console.WriteLine("A в степени B = " + degree);