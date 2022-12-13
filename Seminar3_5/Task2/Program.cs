// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//Методы
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void Replacement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

//Дано
int length = 12;
int min = -9;
int max = 9;
//Создание массива
int[] array = CreateArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
//Анализ данных
Replacement(array);
