//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

//Методы
int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1]);
}
//Выполнение программы
int[] array = CreateArray(8);
PrintArray(array);