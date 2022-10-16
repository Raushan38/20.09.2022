// задача 51: задайте двумерный массив 
// и найдите сумму элементов находящихся 
// на главной диогонали, с индексами
// (0,0) (1,1) и так далее

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

/// сумма элементов главное диогонали = 1+9+2=12

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int sumElemDiagonal = FindSumElemDiagonal(array2D);
System.Console.WriteLine("сумма элементов главное диогонали -> " + sumElemDiagonal);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;  
}

int FindSumElemDiagonal(int[,] matrix)
{
    int sum = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];
        }
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}





