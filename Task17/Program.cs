// 17. Напишите прогрмамму кторая принимает на вход координаты 
// (X и Y) причем X не равен 0 и Y не равен 0 
// и выдает номер четверти плоскости в которой находится точка

// System.Console.WriteLine("Введите координаты точки ");
// System.Console.Write("X: ");
// int xC = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Y: ");
// int yC = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xC, yC);
// Console.WriteLine(quarter == 0 ? "Введены некорректные координаты" : quarter);

// int Quarter(int x, int y)
// {
    // if (x > 0 && y > 0) return 1;
    // if (x < 0 && y > 0) return 2;
    // if (x < 0 && y < 0) return 3;
    // if (x > 0 && y < 0) return 4;
    // return 0;
// }


/// или можно еще так

System.Console.WriteLine("Введите координаты точки ");
System.Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

string quarterStr = QuarterStr(xC, yC);
Console.WriteLine(quarterStr);

string QuarterStr(int x, int y)
{
    if (x > 0 && y > 0) return "первая четверть";
    if (x < 0 && y > 0) return "вторая четверть";
    if (x < 0 && y < 0) return "третья четверть";
    if (x > 0 && y < 0) return "четвертая четверть";
    return "Введены некорректные координаты";
}
