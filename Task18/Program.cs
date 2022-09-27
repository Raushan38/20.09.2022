// задача 18. Напишите прогрмамму кторая по заданному номеру 
// четверти показывает диапозон возможных 
// координат точек в этой четверти (x и y)

Console.WriteLine("Введите четверть: ");
int quater = Convert.ToInt32(Console.ReadLine());

void Diaposon(int quater1)
{
    if (quater1 == 1) Console.WriteLine("x > 0, y > 0");
    else if (quater1 == 2) Console.WriteLine("x < 0, y > 0");
    else if (quater1 == 3) Console.WriteLine("x < 0, y < 0");
    else if (quater1 == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Введены некорректные данные");
}

Diaposon(quater);

// или так 
Console.WriteLine("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = Quarter(quarter);
System.Console.WriteLine(result);

string quarter (int quater2)
{
   if (quater2 == 1) return "x > 0 y > 0";
   if (quater2 == 2) return "x < 0 y > 0";
   if (quater2 == 3) return "x < 0 y < 0";
   if (quater2 == 4) return "x > 0 y < 0";
   return "Введены некорректные данные";
}