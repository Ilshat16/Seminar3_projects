// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] ChangeMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < columns; i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[columns - 1, i];
        matrix[columns - 1, i] = temp;
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
int[,] matrix = FillMatrix(rows, columns, 0, 9);
PrintMatrix(matrix, rows, columns);
Console.WriteLine();
int[,] newMatrix = ChangeMatrix(matrix, rows, columns);
PrintMatrix(newMatrix, rows, columns);