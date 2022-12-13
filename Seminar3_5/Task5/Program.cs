//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

void FindMultipli(int[] array)
{
    int length = array.Length;
    if (length % 2 == 0)
    {
        for (int i = 0; i < length / 2; i++)
        {
            int multi = array[i] * array[length - 1 - i];
            Console.Write($"{multi}, ");
        }
    }
    else
    {
        for (int i = 0; i < (length / 2) + 1; i++)
        {
            int multi = array[i] * array[length - 1 - i];
            Console.Write($"{multi}, ");
        }
    }
}

//Дано
int length = 9;
int max = 9;
//Создание массива
int[] array = CreateArray(length, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
//Анализ данных
FindMultipli(array);