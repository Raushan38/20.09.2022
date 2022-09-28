// Задача 19. Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("введите  5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10000;
int secondDigit = (number % 10000) / 1000;
int fourthDigit = (number % 100) / 10;
int fifthDigit = (number % 100) % 10;

{
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
	{
        Console.WriteLine($"{number} - Палиндром");
    }
	else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
 
