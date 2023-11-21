// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] matrix = new char[,]
{
    {'-', 'b', 'c', 'd', 'e'},
    {'r', 't', '-', 'u', 'i'},
    {'w', '-', 'q', '!', 'm'},
};

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);

string MatrixString (char[,] matrix)
{
    string result = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        result = result + matrix[i,j] + result;
       }
    }
    return result;
}
Console.WriteLine(MatrixString(matrix));

