// 1.Напишите прогамму, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// а = 9, b = -3 -> да
// а = -3, b = 9 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (num1 == square)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}