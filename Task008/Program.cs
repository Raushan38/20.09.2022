Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i = i + 1) // объявили массив
{
    if (i % 2 == 0) // проверка на четность
    {
         Console.Write(i + " ");
    }
}