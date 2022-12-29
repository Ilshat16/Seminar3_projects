// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 

int PrintNumbers(int number)
{
    if (number == 1) return number;
    System.Console.Write($"{PrintNumbers(number - 1)}, ");
    return number;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите число: ");
System.Console.WriteLine(PrintNumbers(number));