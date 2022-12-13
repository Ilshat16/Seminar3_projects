//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// void SearchNum(int[] array, int number)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) 
//          {
//              count += 1;
//              break;
//          }
//     }
//     if (count > 0) Console.WriteLine($"Число {number} присутствует в массиве");
//     else Console.WriteLine($"Числа {number} нет в массиве");
// }

void SearchNum(int[] array, int number)
{
    bool test = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) test = true;
    }
    if (test) Console.WriteLine($"Число {number} присутствует в массиве");
    else Console.WriteLine($"Числа {number} нет в массиве");
}

//Дано
int length = 12;
int min = -9;
int max = 9;
int number = EnterData("Ввелите число: ");
//Создание массива
int[] array = CreateArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
//Анализ данных
SearchNum(array, number);