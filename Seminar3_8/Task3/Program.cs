// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


int[] FindCounts(int[,] matrix, int rows, int columns)
{
    int[] counts = new int[10];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < counts.Length; k++)
            {
                if (matrix[i, j] == k) counts[k] += 1;
            }
        }
    }
    return counts;
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
int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, columns, 0, 9);
PrintMatrix(matrix, rows, columns);
int[] counts = FindCounts(matrix, rows, columns);
for (int i = 0; i < counts.Length; i++)
{
    if(counts[i] != 0) Console.WriteLine($"{i} встречается {counts[i]} раз");
}