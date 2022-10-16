// задача 55: задайте двумернный массив и 
// напишите программу которая заменяет 
// строки на столбцы. в случае если это невозможно
// программа должна вывести сообщение


int[,] myArray = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(myArray);
Console.WriteLine();
bool CheckMatrix(int[,] myArray)
{
    return myArray.GetLength(0) == myArray.GetLength(1);
}

if (CheckMatrix(myArray))
    PrintMatrix(ReplaceRowsColums(myArray));
else
    Console.WriteLine("невозможно заменить строки на столбцы");

int[,] ReplaceRowsColums(int[,] matrix)
{
    int[,] newArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[i, j] = matrix[j, i];
        }
    }
    return newArray;
}

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
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
