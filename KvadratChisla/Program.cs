// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 * n1 == n2) Console.WriteLine($"Число {n2} является квадратом {n1}");
else Console.WriteLine($"Число {n2} не является квадратом {n1}");