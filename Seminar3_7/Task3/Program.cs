// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] ChangeMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if (i % 2 != 0 & j % 2 != 0) matrix[i,j] = matrix[i,j] * matrix[i,j];
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

int[,] FillMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Запрашиваем у пользователя количество строк и столбцов.
int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
// Создаем двухмерного массива и заполняем его случайными числами.
int[,] matrix = FillMatrix(rows, columns, 1, 10);
PrintMatrix(matrix, rows, columns);
Console.WriteLine();
int[,] newMatrix = ChangeMatrix(matrix, rows, columns);
PrintMatrix(newMatrix, rows, columns);