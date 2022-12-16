// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

//Методы
int[] CreateArray(int length, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(max);
    }
    return array;
}

int[] CopyingArray(int[] arr, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}
//Начальные данные
int length = 10;
int max = 9;
//Создание массива
int[] array = CreateArray(length, max);
Console.WriteLine($"Оригинал - [{string.Join(", ", array)}]");
//Копирование массива
int[] arrayCopy = CopyingArray(array, length);
//Вывод массва
Console.WriteLine($"Копия - [{string.Join(", ", arrayCopy)}]");