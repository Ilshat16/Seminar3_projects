// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

void SearchNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 & array[i] <= 99) count += 1;
    }
    Console.WriteLine($"В массиве {count} цифр лежат в отрезке [10,99]");
}

//Дано
int length = 12;
int max = 123;
//Создание массива
int[] array = CreateArray(length, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
//Анализ данных
SearchNum(array);