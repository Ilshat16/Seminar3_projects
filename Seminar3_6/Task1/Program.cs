// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

void UnwrapArray(int[] arr, int length)
{
    int temp = 0;
    for (int i = 0; i < length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[length - 1 - i];
        arr[length - 1 - i] = temp;
    }
}
//Начальные данные
int length = 10;
int max = 9;
//Создание массива
int[] array = CreateArray(length, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
//Переворот массива
UnwrapArray(array, length);
//Вывод массва
Console.WriteLine($"[{string.Join(", ", array)}]");
