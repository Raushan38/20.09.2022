// задача 22. напишите программу которая
// принимает на вход число (N) и выдает
// таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1,4

Console.WriteLine("введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"|{counter, 3} | {counter * counter, 5} |");
        counter++;
    }
}
if (num > 0) SquareTable(num);
else Console.WriteLine("введите корректное значение");