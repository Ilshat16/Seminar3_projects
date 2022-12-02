// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
int result = n1 % n2;
if (result == 0) Console.WriteLine($"Число {n1} кратно {n2}");
else 
{
    Console.WriteLine($"Число {n1} некратно {n2}");
    Console.WriteLine($"Остатком от деления будет {result}");
}