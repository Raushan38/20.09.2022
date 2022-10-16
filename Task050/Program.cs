// Задача 50. Напишите программу, которая на 
// вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array2D = new int [4,4];
CreateMatrixRndInt(array2D);

if (n > array2D.GetLength(0) || m > array2D.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array2D[n-1,m-1]}");
}

Printmatrix(array2D);

void CreateMatrixRndInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(1, 10);
            }   
        }
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }   
        Console.Write("|");
        Console.WriteLine(""); 
    }
}