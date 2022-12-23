// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


int[,] ChangeMatrix(int[,] matrix, int rows, int columns)
{
    int[,] resultMatrix = new int[rows - 1, columns - 1];
    int x = 0;
    int y = 0;
    int minNum = matrix[x, y];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (minNum > matrix[i, j])
            {
                minNum = matrix[i, j];
                x = i;
                y = j;
            }
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == x || j == y) continue;
            else
            {
                int k = i;
                int l = j;
                if (i > x) k = i - 1;
                if (j > y) l = j - 1;
                resultMatrix[k, l] = matrix[i, j];
            }
        }
    }
    return resultMatrix;
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
int[,] resultMatrix = ChangeMatrix(matrix, rows, columns);
PrintMatrix(resultMatrix, rows, columns);