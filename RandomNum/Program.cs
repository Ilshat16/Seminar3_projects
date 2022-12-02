// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
int n1 = number / 10;
int n2 = number % 10;
int max = n1;
if (n2 > n1) max = n2;
Console.WriteLine($"В числе {number} максимальным является {max}");