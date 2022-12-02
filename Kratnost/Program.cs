// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
int result = n1 % n2;
if (result == 0) Console.WriteLine($"Число {n2} кратно {n1}");
else 
{
    Console.WriteLine($"Число {n2} некратно {n1}");
    Console.WriteLine($"Остатком от деления будет {result}");
}