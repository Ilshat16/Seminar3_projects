Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = -number;
while (num1 <= number)
{
    Console.Write($"{num1}, ");
    num1++;
}
