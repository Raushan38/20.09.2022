Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) // % - находит дробное значение числа после деления
{ 
    Console.WriteLine("четное число");   
}
else 
{
    Console.WriteLine("нечетное число");  
}