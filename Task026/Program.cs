// Задача 26. напишите программу которая принимает 
// на вход число и  выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89123 -> 5

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int QuantityNumbers(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}
int res = QuantityNumbers(Math.Abs(number));
Console.WriteLine(res);