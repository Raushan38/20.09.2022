// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int lenArray = ReadInt("длина массива: ");

int[] Array = new int[lenArray];
Random rnd = new Random();
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rnd.Next(1,20);
    Console.Write(Array[i] + " ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}