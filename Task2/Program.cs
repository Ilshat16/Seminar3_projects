Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является - {result}");