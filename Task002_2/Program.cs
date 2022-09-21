Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}
