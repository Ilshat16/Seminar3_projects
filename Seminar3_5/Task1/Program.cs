//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
void SumElements(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел в массиве равна: {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел в массиве равна: {sumNegative}");
}
//Дано
int length = 12;
int min = -9;
int max = 9;
//Создание массива
int[] array = CreateArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
//Анализ данных
SumElements(array);