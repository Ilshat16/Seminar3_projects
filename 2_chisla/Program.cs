Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int result = number1 * number1;
if (result == number2)
{
    Console.WriteLine($"{number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"{number1} не является квадратом числа {number2}");
}