// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
int n1 = number / 100;
int n3 = number % 10;
int result = n1 * 10 + n3;
Console.WriteLine($"Если из числа {number}  удалить вторую цифру получим {result}");