// задача 53: задайте двумерный массив и 
// напишите программу которая поменяет 
// местами первую и последную строку массива

int[,] myarray = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(myarray);
NewArray(myarray);
Console.WriteLine();
PrintMatrix(myarray);


void NewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
         int obj = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = obj;
    }
    
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}



