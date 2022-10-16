// Задача 52. Задайте двумерный массив 
// из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

Console.WriteLine("количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int [,] array2D = new int [n,m];
CreateMatrixRndInt(array2D);

for (int j = 0; j < array2D.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        avarage = (avarage + array2D[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
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