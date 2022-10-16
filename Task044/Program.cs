// задача 44: не использую рекрусию введите 
// N числел фибоначчи. первые два числа Ф: 0 и 1

// если N = 5 -> 01123
// если N = 3 -> 011
// если N = 7 -> 0112358


Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
PrintFibonacci(number);

void PrintFibonacci(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    Console.Write($"{firstNum} {secondNum} ");
    for (int i = 2; i < num; i++)
    {
        int nextNum = firstNum + secondNum;
        Console.WriteLine($"{nextNum} ");
        firstNum = secondNum;
        secondNum = nextNum;
    }
}