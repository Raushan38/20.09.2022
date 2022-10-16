// напишите прогрпмму которая будет
// преобразовывать десятичное число в 
// двочное

// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int binaryNumUnreversed = ConverNumberToBinary(number);
Console.WriteLine($"{number} -> {binaryNumUnreversed}");
int ConverNumberToBinary (int num)
{
    int binaryNumUnreversed = 0;
    int count = 1;
    while (num > 0)
    {
        binaryNumUnreversed = binaryNumUnreversed + num % 2 * count;
        count = count*10;
        num = num / 2;
    }
    return binaryNumUnreversed;
}

// int ConverNumberToBinaryRecurtion (int num)
// {
//    if (num < 2) return num % 2;
//    else return
///}
