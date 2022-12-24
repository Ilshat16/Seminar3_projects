// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int[,] CreatePascalTriangle(int rows)
{
    int[,] matrix = new int[rows, rows * 2 + 1];
    matrix[0, rows] = 1;
    for (int i = 1; i < rows; i++)
    {
        for (int j = 0; j < rows * 2 + 1; j++)
        {
            if (matrix[i, j] == 0)
            {
                int n1 = 0;
                int n2 = 0;
                int ni = i - 1;
                int n1j = j - 1;
                int n2j = j + 1;
                if (ni >= 0 & n1j >= 0 & n2j < rows * 2 + 1)
                {
                    n1 = matrix[ni, n1j];
                    n2 = matrix[ni, n2j];
                }
                matrix[i, j] = n1 + n2;
            }
        }
    }
    return matrix;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write("  ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = EnterData("Введите количество строк треугольника Паскаля: ");
int[,] pascalTriangle = CreatePascalTriangle(rows);
PrintMatrix(pascalTriangle);
